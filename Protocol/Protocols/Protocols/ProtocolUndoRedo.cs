using System.Collections.Generic;

namespace Protocols
{
    public class UndoManager
    {
        public static Stack<IProtocolNodeCmd> UndoStack { get; } = new Stack<IProtocolNodeCmd>();

        public static Stack<IProtocolNodeCmd> RedoStack { get; } = new Stack<IProtocolNodeCmd>();

        public static bool CanUndo
        {
            get { return UndoStack.Count > 0; }
        }

        public static bool CanRedo
        {
            get { return RedoStack.Count > 0; }
        }

        public void Invoke(IProtocolNodeCmd cmd)
        {
            cmd.Execute();
        }
    }

    public abstract class ProtocolNodeCmd : IProtocolNodeCmd
    {
        public ProtocolNode Parent { get; set; }

        public ProtocolNode Child { get; set; }

        public abstract void Execute();
        public abstract void UndoExecute();
    }

    public class AddCmd : ProtocolNodeCmd
    {
        public AddCmd(ProtocolNode parent, ProtocolNode child)
        {
            Parent = parent;
            Child = child;
        }

        public override void Execute()
        {
            var id = UniqueId.GetId();
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
        private readonly List<ProtocolNode> mList;
        private readonly int mOriginalId;

        public RemoveCmd(ProtocolNode parent, ProtocolNode child, List<ProtocolNode> list)
        {
            Parent = parent;
            Child = child;
            mOriginalId = child.Id;
            mList = list;
        }

        public override void Execute()
        {
            if (mList != null)
            {
                foreach (var node in mList)
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
                foreach (var node in mList)
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
        private readonly ProtocolNode mCurrentNode;
        private int mOriginalIndex;

        public NudgeUpCmd(ProtocolNode currentNode)
        {
            mCurrentNode = currentNode;
        }

        public override void Execute()
        {
            if (mCurrentNode.PrevNode != null)
            {
                var parent = (ProtocolNode) mCurrentNode.Parent;
                mOriginalIndex = mCurrentNode.Index;
                var index = mCurrentNode.PrevNode.Index;
                mCurrentNode.Remove();
                parent.Nodes.Insert(index, mCurrentNode);
                UndoManager.UndoStack.Push(this);
            }
        }

        public override void UndoExecute()
        {
            var parent = (ProtocolNode) mCurrentNode.Parent;
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
        private readonly ProtocolNode mCurrentNode;
        private int mOriginalIndex;

        public NudgeDownCmd(ProtocolNode currentNode)
        {
            mCurrentNode = currentNode;
        }

        public override void Execute()
        {
            if (mCurrentNode.NextNode != null)
            {
                var parent = (ProtocolNode) mCurrentNode.Parent;
                mOriginalIndex = mCurrentNode.Index;
                var index = mCurrentNode.NextNode.Index;
                mCurrentNode.Remove();
                parent.Nodes.Insert(index, mCurrentNode);
                UndoManager.UndoStack.Push(this);
            }
        }

        public override void UndoExecute()
        {
            var parent = (ProtocolNode) mCurrentNode.Parent;
            mCurrentNode.Remove();
            parent.Nodes.Insert(mOriginalIndex, mCurrentNode);

            UndoManager.RedoStack.Push(this);
        }
    }

    public class MoveCmd : ProtocolNodeCmd
    {
        public MoveCmd(ProtocolNode source, ProtocolNode parent, ProtocolNode child)
        {
            Source = source;
            SourceParent = (ProtocolNode) source.Parent;
            Index = SourceParent.Nodes.IndexOf(Source);
            Parent = parent;
            Child = child;
        }

        public int Index { get; set; }

        public ProtocolNode SourceParent { get; set; }

        public ProtocolNode Source { get; set; }

        public override void Execute()
        {
            Parent.Nodes.AddRange(new /*System.Windows.Forms.TreeNode*/[] {Child});
            Parent.ExpandAll();
            if (Source != null && Source.Parent != null)
            {
                Source.Parent.Nodes.Remove(Source);
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
        public override void Execute()
        {
            if (UndoManager.RedoStack.Count > 0)
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