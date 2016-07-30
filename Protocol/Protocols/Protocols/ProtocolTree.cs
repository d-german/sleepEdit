using System;
using System.Collections.Generic;
using System.Text;

namespace Protocols
{
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class Protocol_old
    {
        public delegate void saveProtocol();
        public event saveProtocol Save;

        public void emitSave()
        {
            try
            {
	            Save();
            }
            catch 
            {
            	
            }
        }

        public Protocol_old()
        {
            ProtocolReader_old reader = new ProtocolReader_old(mNode);
        }
        public Protocol_old(string path)
        {
            Path = path;
            ProtocolReader_old reader = new ProtocolReader_old(mNode);
        }

        private ProtocolNode_old mNode = new ProtocolNode_old(new Element());

        public ProtocolNode_old Node
        {
            get { return mNode; }
            set { mNode = value; }
        }

        public List<string> sectionList()
        {
            List<string> list = new List<string>();
            foreach (ProtocolNode_old node in mNode.NodeList)
            {
                list.Add(node.Element.Text);
            }
            return list;            
        }

        public static string Path = @"F:\protocol.xml";
        private ProtocolNode_old mNewNode = new ProtocolNode_old(new Element());

        private static ProtocolNode_old foundNode = null;

        public void save()
        {
            ProtocolWriter_old writer = new ProtocolWriter_old(mNode);
        }

        public void addSection(string text)
        {
            ProtocolNode_old sectionNode = new ProtocolNode_old(new Element());
/*            sectionNode.Element.GotoSection = "0";*/
            sectionNode.Element.Text = text;
            sectionNode.IsSection = true;
            mNode.NodeList.Add(sectionNode);
            ProtocolNode_old newNode = new ProtocolNode_old(new Element());
            newNode.Element.Text = "New Node";
            sectionNode.NodeList.Add(newNode);
        }
        public bool removeSection(ProtocolNode_old sectionNode)
        {
            return mNewNode.NodeList.Remove(sectionNode);
        }
        public bool removeSection(string text)
        {
            return mNode.NodeList.Remove(getSection(text));
        }
        public ProtocolNode_old getSection(string text)
        {
            foreach (ProtocolNode_old node in mNode.NodeList)
            {
              if (node.Element.Text == text)
              {
                  return node;
              }
                
            }
            return null;
        }
        public int getSectionIndex(string section)
        {
            return mNode.NodeList.IndexOf(getSection(section)) + 1 ;
        }

        public bool insertChild(ProtocolNode_old node, string nodeText, string gotoSection, List<string> subTextList)
        {
            if (node == null)
            {
                System.Console.WriteLine("Cant add to a null node");
                return false;
            }
            processNewNode(nodeText, gotoSection, subTextList, mNewNode);

            if (node.Equals(mNode))
            {
                mNode.NodeList.Add(node);
            }
            else
            {
                _insertChild(mNode, node);
            }

            return true;
        }

        private void _insertChild(ProtocolNode_old parentNode, ProtocolNode_old childNode)
        {
            foreach (ProtocolNode_old n in parentNode.NodeList)
            {
                if (n.Equals(childNode))
                {
                    childNode.NodeList.Add(mNewNode);
                    break;
                }
                _insertChild(n, childNode);
            }
        }

        public void insertSibling(ProtocolNode_old node, string nodeText, string gotoSection, List<string> subTextList)
        {

            processNewNode(nodeText, gotoSection, subTextList, mNewNode);
            _insertSibling(mNode, node);

        }

        private void _insertSibling(ProtocolNode_old siblingNode, ProtocolNode_old curNode)
        {
            foreach (ProtocolNode_old n in siblingNode.NodeList)
            {
                if (n.NodeList.Contains(curNode))
                {
                    int index = n.NodeList.IndexOf(curNode);
                    if (index == n.NodeList.Count - 1)
                    {
                        n.NodeList.Add(mNewNode);
                    }
                    else
                        n.NodeList.Insert(index + 1, mNewNode);
                    break;
                }
                _insertSibling(n, curNode);
            }
        }

        public bool deleteNode(ProtocolNode_old childNode)
        {
            if (childNode == null || !childNode.IsLeaf || childNode.Equals(mNode))
            {
                System.Console.WriteLine("Cant delete a nonLeaf node or root node");
                return false;
            }
            _deleteNode(mNode, childNode);
            return true;
        }

        private void _deleteNode(ProtocolNode_old parentNode, ProtocolNode_old childNode)
        {
            foreach (ProtocolNode_old n in parentNode.NodeList)
            {
                if (parentNode.NodeList.Contains(childNode))
                {
                    parentNode.NodeList.Remove(childNode);
                    break;
                }
                _deleteNode(n, childNode);
            }
        }

        public ProtocolNode_old getNode(int id)
        {
            ProtocolNode_old node = null;
            _getNode(mNode, id);
            node = foundNode;
            foundNode = null;
            return node;
        }

        private void _getNode(ProtocolNode_old node, int id)
        {
            foreach (ProtocolNode_old n in node.NodeList)
            {
                if (n.Id == id)
                {
                    foundNode = n;
                    break;
                }
                _getNode(n, id);
            }
        }

        public void _print(ProtocolNode_old node)
        {
            foreach (ProtocolNode_old n in node.NodeList)
            {
                print(n);
                _print(n);
            }
        }

        private void print(ProtocolNode_old node)
        {
            string str = node.Id.ToString() + " ";
            string tab = "";

            for (int i = 0; i < node.Depth; i++)
            {
                tab += "\t";
            }
            System.Console.WriteLine(str + tab + node.Element.Text);
//             foreach(string gotostr in node.Element.GotoList)
//             {
//                 System.Console.WriteLine(tab + gotostr);
//             }
             foreach (string subString in node.Element.SubTextList)
            {
                System.Console.WriteLine(tab + subString);
            }
        }

        private static void processNewNode(string nodeText, string gotoSection, List<string> subTextList, ProtocolNode_old node)
        {
            if (node == null)
            {
                node = new ProtocolNode_old(new Element());
            }             
	            node.Element.Text = nodeText;            
/*	            node.Element.GotoSection = gotoSection;*/
                        
            if (subTextList != null)
            {
	            node.Element.SubTextList = subTextList;
            }
        }
    };

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class ProtocolNode_old
    {
        private static int ID = 0;
        public ProtocolNode_old(Element element)
        {
            mElement = element;
            mId = ID++;

        }
        private List<ProtocolNode_old> mNodeList = new List<ProtocolNode_old>();
        private Element mElement = new Element();
        private bool mChecked = false;
        private int mId;
        private int mDepth = 0;
        private bool mIsSection = false;
        private bool mIsLeaf = false;

        public int Depth
        {
            get { return mDepth; }
            set { mDepth = value; }
        }
        public List<ProtocolNode_old> NodeList
        {
            get { return mNodeList; }
            set { mNodeList = value; }
        }
        public int Id
        {
            get { return mId; }            
        }
        public Element Element
        {
            get { return mElement; }
            set { mElement = value; }
        }
        public bool Checked
        {
            get { return mChecked; }
            set { mChecked = value; }
        }
        public bool IsSection
        {
            get { return mIsSection; }
            set { mIsSection = value; }
        }
        public bool IsLeaf
        {
            get {
                mIsLeaf = mNodeList.Count == 0;
                
                return mIsLeaf;
            }

        }
    };

}



//     public class ProtocolTree
//     {
// 
//         public ProtocolTree()
//         {
//             //init();
//             //             populateTreeV1();
//             //             visitAll(nodeA);
//            // populateTreeV2();
//         }
// 
//        public List<ProtocolTreeNode> mNodeListV2 = new List<ProtocolTreeNode>();
// 
// 
// 
//         public void init()
//         {
// 
//             A.mText = "Section 1 Poison Ivy";
//             A.mId = 0;
//             A.mGotoId = -1;
// 
// 
//             B.mText = "Section 2 Snake Bite";
//             B.mId = 1;
//             B.mGotoId = -1;
// 
// 
//             C.mText = "Section 3 Poison Inhaled or Swallowed";
//             C.mId = 2;
//             C.mGotoId = -1;
// 
// 
// 
//             D.mText = "Section 4 Insect or Spider Bite";
//             D.mId = 3;
//             D.mGotoId = -1;
// 
// 
// 
//             E.mText = "Section 5 Seek Medical Attention";
//             E.mId = 4;
//             E.mGotoId = -1;
// 
// 
//             F.mText = "Section 6 Done";
//             F.mId = 5;
//             F.mGotoId = -1;
// 
// 
// 
//             G.mText = "How recent?";
//             G.mId = 6;
//             G.mGotoId = -1;
//             G.mDepth = 1;
// 
// 
// 
//             H.mText = "Poison Ivy is wide spread and painful.";
//             H.mId = 7;
//             H.mGotoId = 4;
//             H.mSubTextList.Add("This is a test.");
//             H.mSubTextList.Add("kjsjksjk d");
//             H.mDepth = 1;
// 
// 
// 
//             I.mText = "Monitor patient.";
//             I.mId = 8;
//             I.mGotoId = 5;
//             I.mDepth = 1;
// 
// 
// 
//             J.mText = "Snake is identified-If not why?";
//             J.mId = 9;
//             J.mGotoId = -1;
//             J.mSubTextList.Add("It spit at me and flew away!");
//             J.mSubTextList.Add("I fainted and it ran away.");
//             J.mDepth = 1;
// 
// 
// 
//             K.mText = "Clean the bite with soap and water--GOTO Seek Medical Attention.";
//             K.mId = 10;
//             K.mGotoId = 4;
//             K.mDepth = 1;
// 
// 
//             L.mText = "Check ABCH treat for shock.";
//             L.mId = 11;
//             L.mGotoId = -1;
//             L.mDepth = 1;
// 
// 
//             M.mText = "Call the poison control center.";
//             M.mId = 12;
//             M.mGotoId = -1;
//             M.mDepth = 1;
// 
// 
// 
//             N.mText = "Catch the insect or spider--if not why?";
//             N.mId = 13;
//             N.mGotoId = -1;
//             N.mSubTextList.Add("It jumped off a cliff!");
//             N.mDepth = 1;
// 
// 
//             O.mText = "Stinger?";
//             O.mId = 14;
//             O.mGotoId = -1;
//             O.mDepth = 1;
// 
// 
//             P.mText = "Patient is allergic.";
//             P.mId = 15;
//             P.mGotoId = -1;
//             P.mDepth = 1;
// 
// 
//             Q.mText = "Recent--Wash with soap and water.";
//             Q.mId = 16;
//             Q.mGotoId = -1;
//             Q.mDepth = 2;
// 
// 
//             R.mText = "Not Recent--Provide cool bath and calamine lotion.";
//             R.mId = 17;
//             R.mGotoId = -1;
//             R.mDepth = 2;
// 
// 
//             S.mText = "Yes--Scrape the stinger do not squeeze!";
//             S.mId = 18;
//             S.mGotoId = -1;
//             S.mDepth = 2;
// 
// 
//             T.mText = "NO-Clean the bite. Apply an ice pack.";
//             T.mId = 19;
//             T.mGotoId = -1;
//             T.mDepth = 2;
// 
// 
//             U.mText = "Yes--Check ABCH, treat for shock--GOTO Seek Medical Attention.";
//             U.mId = 20;
//             U.mGotoId = 4;
//             U.mDepth = 2;
// 
// 
//             V.mText = "No--clean the bite--GOTO Seek Medical Attention.";
//             V.mId = 21;
//             V.mGotoId = 4;
//             V.mDepth = 2;
// 
//         }
// 
//         
// 
//         private ProtocolTreeNode protocolNode;
//         public Protocols.ProtocolTreeNode ProtocolNode
//         {
//             get { return protocolNode; }
//         }
//         public void populateTreeV2()
//         {
//             Element protocolElement = new Element();
//             protocolElement.mText = "Poisons and Bites";
//             protocolNode = new ProtocolTreeNode(protocolElement);
// 
//             ProtocolTreeNode nodeA = new ProtocolTreeNode(A);
//             ProtocolTreeNode nodeG = new ProtocolTreeNode(G);
//             ProtocolTreeNode nodeQ = new ProtocolTreeNode(Q);
//             ProtocolTreeNode nodeR = new ProtocolTreeNode(R);
//             ProtocolTreeNode nodeH = new ProtocolTreeNode(H);
//             ProtocolTreeNode nodeI = new ProtocolTreeNode(I);
// 
// 
// 
//             protocolNode.mNodeList.Add(nodeA);
//             nodeA.mNodeList.Add(nodeG);
//             nodeA.mNodeList.Add(nodeH);
//             nodeA.mNodeList.Add(nodeI);
// 
//             nodeG.mNodeList.Add(nodeQ);
//             nodeG.mNodeList.Add(nodeR);
// 
// 
// 
//             ProtocolTreeNode nodeB = new ProtocolTreeNode(B);
//             ProtocolTreeNode nodeJ = new ProtocolTreeNode(J);
//             ProtocolTreeNode nodeK = new ProtocolTreeNode(K);
// 
//             protocolNode.mNodeList.Add(nodeB);
//             nodeB.mNodeList.Add(nodeJ);
//             nodeB.mNodeList.Add(nodeK);
// 
// 
//             ProtocolTreeNode nodeC = new ProtocolTreeNode(C);
//             ProtocolTreeNode nodeL = new ProtocolTreeNode(L);
//             ProtocolTreeNode nodeM = new ProtocolTreeNode(M);
// 
//             protocolNode.mNodeList.Add(nodeC);
//             nodeC.mNodeList.Add(nodeL);
//             nodeC.mNodeList.Add(nodeM);
// 
// 
//             ProtocolTreeNode nodeD = new ProtocolTreeNode(D);
//             ProtocolTreeNode nodeN = new ProtocolTreeNode(N);
//             ProtocolTreeNode nodeO = new ProtocolTreeNode(O);
//             ProtocolTreeNode nodeP = new ProtocolTreeNode(P);
//             ProtocolTreeNode nodeS = new ProtocolTreeNode(S);
//             ProtocolTreeNode nodeT = new ProtocolTreeNode(T);
//             ProtocolTreeNode nodeU = new ProtocolTreeNode(U);
//             ProtocolTreeNode nodeV = new ProtocolTreeNode(V);
// 
//             protocolNode.mNodeList.Add(nodeD);
// 
//             nodeD.mNodeList.Add(nodeN);
//             nodeD.mNodeList.Add(nodeO);
//             nodeO.mNodeList.Add(nodeS);
//             nodeO.mNodeList.Add(nodeT);
// 
//             nodeD.mNodeList.Add(nodeP);
//             nodeP.mNodeList.Add(nodeU);
//             nodeP.mNodeList.Add(nodeV);
// 
// 
//             ProtocolTreeNode nodeE = new ProtocolTreeNode(E);
//             ProtocolTreeNode nodeF = new ProtocolTreeNode(F);
// 
//             protocolNode.mNodeList.Add(nodeE);
//             protocolNode.mNodeList.Add(nodeF);
// 
//         }
//         
// 
//         Element A = new Element();
//         Element B = new Element();
//         Element C = new Element();
//         Element D = new Element();
//         Element E = new Element();
//         Element F = new Element();
//         Element G = new Element();
//         Element H = new Element();
//         Element I = new Element();
//         Element J = new Element();
//         Element K = new Element();
//         Element L = new Element();
//         Element M = new Element();
//         Element N = new Element();
//         Element O = new Element();
//         Element P = new Element();
//         Element Q = new Element();
//         Element R = new Element();
//         Element S = new Element();
//         Element T = new Element();
//         Element U = new Element();
//         Element V = new Element();
//        
//     };

