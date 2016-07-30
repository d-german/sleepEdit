using System;
using System.Collections.Generic;
using System.Text;

namespace Protocols
{
    public class UndoManager
    {
        public void Invoke(IProtocolNodeCmd cmd)
        {
            cmd.Execute();
        }
        private static Stack<IProtocolNodeCmd> mUndoStack = new Stack<IProtocolNodeCmd>();
        public static Stack<IProtocolNodeCmd> UndoStack
        {
            get { return UndoManager.mUndoStack; }
        }
        private static Stack<IProtocolNodeCmd> mRedoStack = new Stack<IProtocolNodeCmd>();

        public static Stack<IProtocolNodeCmd> RedoStack
        {
            get { return UndoManager.mRedoStack; }
        }

        public static bool CanUndo
        {
            get { return UndoStack.Count > 0; }
            
        }
        public static bool CanRedo
        {
            get { return RedoStack.Count > 0; }
           
        }
    };

    abstract public class ProtocolNodeCmd : IProtocolNodeCmd
    {
        public ProtocolNodeCmd()
        {
        }
        abstract public void Execute();
        abstract public void UndoExecute();

        private ProtocolNode mParent;
        public Protocols.ProtocolNode Parent
        {
            get { return mParent; }
            set { mParent = value; }
        }
        private ProtocolNode mChild;
        public Protocols.ProtocolNode Child
        {
            get { return mChild; }
            set { mChild = value; }
        }
    };

    public class AddCmd : ProtocolNodeCmd
    {
        public AddCmd(ProtocolNode parent, ProtocolNode child)
        {
            base.Parent = parent;
            base.Child = child;
        }
        public override void Execute()
        {
            int id = UniqueId.GetId();
            Child.Id = id;
            Parent.Nodes.Add(Child);           
            UndoManager.UndoStack.Push(this);           
        }

        public override void UndoExecute()
        {           
            Parent.Nodes.Remove(Child);
            UndoManager.RedoStack.Push(this);
        }
    }

    public class RemoveCmd : ProtocolNodeCmd
    {
        public RemoveCmd(ProtocolNode parent, ProtocolNode child, List<ProtocolNode> list)
        {
            base.Parent = parent;
            base.Child = child;
            mOriginalId = child.Id;
            mList = list;
        }
        private List<ProtocolNode> mList;
        private int mOriginalId; 
        public override void Execute()
        {
            if (mList != null)
            {
                foreach (ProtocolNode node in mList)
                {
                    node.LinkId = -1;
                }
            }
            Parent.Nodes.Remove(Child);
            UndoManager.UndoStack.Push(this);           
        }
        public override void UndoExecute()
        { 
            if (mList != null)
            {
                foreach(ProtocolNode node in mList)
                {
                    node.LinkId = mOriginalId;
                }
            }
            Parent.Nodes.Add(Child);
            UndoManager.RedoStack.Push(this);
        }
    }

    public class NudgeUpCmd : ProtocolNodeCmd
    {
        public NudgeUpCmd(ProtocolNode currentNode)
        {
            mCurrentNode = currentNode;
        }
        private int mOriginalIndex = 0;
        private ProtocolNode mCurrentNode = null;
        public override void Execute()
        {
            if (mCurrentNode.PrevNode != null)
            {
                ProtocolNode parent = (ProtocolNode)mCurrentNode.Parent;
                mOriginalIndex = mCurrentNode.Index;
                int index =  mCurrentNode.PrevNode.Index;
                mCurrentNode.Remove();
                parent.Nodes.Insert(index, mCurrentNode);
                UndoManager.UndoStack.Push(this);
            }


        }
        public override void UndoExecute()
        {
            ProtocolNode parent = (ProtocolNode) mCurrentNode.Parent;
            mCurrentNode.Remove();
            parent.Nodes.Insert(mOriginalIndex, mCurrentNode);
            UndoManager.RedoStack.Push(this);
        }
    }
//     public class SetLinkCmd : ProtocolNodeCmd
//     {
//        public SetLinkCmd( ProtocolNode currentNode, int id )
//         {
//             mNode = currentNode;
//             mOriginalId = currentNode.LinkId;
//             mCurId = id;
//         }
//         int mCurId = 0;
//         int mOriginalId = 0;  
//         ProtocolNode mNode = null; 
// 
//         public override void Execute()
//         {
//             mNode.LinkId = mCurId;
//             UndoManager.UndoStack.Push(this);            
//         }
//         public override void UndoExecute()
//         {
//             mNode.LinkId = mOriginalId;
//             UndoManager.RedoStack.Push(this);
//         }
//     }
    public class NudgeDownCmd : ProtocolNodeCmd
    {
        public NudgeDownCmd(ProtocolNode currentNode)
        {
            mCurrentNode = currentNode;
        }
        private int mOriginalIndex =0;
        private ProtocolNode mCurrentNode = null;
        public override void Execute()
        {           
            if (mCurrentNode.NextNode != null)
            {
                ProtocolNode parent = (ProtocolNode)mCurrentNode.Parent;
                mOriginalIndex = mCurrentNode.Index;
                int index =  mCurrentNode.NextNode.Index;
                mCurrentNode.Remove();
                parent.Nodes.Insert(index, mCurrentNode);
                UndoManager.UndoStack.Push(this);
            }
            
            
        }
        public override void UndoExecute()
        {
            ProtocolNode parent = (ProtocolNode) mCurrentNode.Parent;
            mCurrentNode.Remove();
            parent.Nodes.Insert(mOriginalIndex, mCurrentNode);
           
            UndoManager.RedoStack.Push(this);
        }


    }

    public class MoveCmd : ProtocolNodeCmd
    {
        public MoveCmd(ProtocolNode source, ProtocolNode parent, ProtocolNode child)
        {
            mSource = source;
            mSourceParent = (ProtocolNode)source.Parent;
            mIndex = mSourceParent.Nodes.IndexOf(mSource);
            base.Parent = parent;
            base.Child = child;
        }
        private ProtocolNode mSource;
        private ProtocolNode mSourceParent;
        private int mIndex = 0;
        public int Index
        {
            get { return mIndex; }
            set { mIndex = value; }
        }
        public ProtocolNode SourceParent
        {
            get { return mSourceParent; }
            set { mSourceParent = value; }
        }
        public Protocols.ProtocolNode Source
        {
            get { return mSource; }
            set { mSource = value; }
        }

        public override void Execute()
        {
            Parent.Nodes.AddRange(new /*System.Windows.Forms.TreeNode*/ProtocolNode[] { Child });
            Parent.ExpandAll();            
            if (mSource != null && mSource.Parent !=null)
            {
	            mSource.Parent.Nodes.Remove(mSource);
	            UndoManager.UndoStack.Push(this); 
            }
          
        }
        public override void UndoExecute()
        {            
            SourceParent.Nodes.Insert(Index, Source);           
            Parent.Nodes.Remove(Child);
            UndoManager.RedoStack.Push(this);
        }
    }

    public class UndoCmd : ProtocolNodeCmd
    {
        public UndoCmd() { }
        public override void Execute()
        {
            if (UndoManager.UndoStack.Count > 0)
            {
                UndoManager.UndoStack.Pop().UndoExecute();
            }
        }

        public override void UndoExecute()
        {
            //todo
        }
    }

    public class RedoCmd : ProtocolNodeCmd
    {
        public RedoCmd(){}

        public override void Execute()
        {
            if (UndoManager.RedoStack.Count >0)
            {              
               	UndoManager.RedoStack.Pop().Execute();              
            }

        }
        public override void UndoExecute()
        {
            //throw new Exception("The method or operation is not implemented.");
        }
    }
}
