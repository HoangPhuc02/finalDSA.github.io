using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlightForm
{
    public class HanhKhach
    {
        public string CMND { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string Phai { get; set; }
        public HanhKhach left;
        public HanhKhach right;
        public HanhKhach(string cmnd, string ho, string ten, string phai)
        {
            this.CMND = cmnd;
            this.Ho = ho;
            this.Ten = ten;
            this.Phai = phai;
            this.left = null;
            this.right = null;
        }
        public HanhKhach()
        {
            CMND = null;
            Ho = null;
            Ten = null;
            Phai = null;
            left = null;
            right = null;
        }
    }
    public class DanhSachHanhKhach
    {
        public static HanhKhach root;

        public DanhSachHanhKhach()
        {
            root = null;
        }
        public static void ThemHK(HanhKhach hk)
        {

            if (root == null)
            {
                root = hk;
            }

            else
            {
                HanhKhach nodeRun = root;
                HanhKhach nodeTruoc = root;
                while (nodeRun != null)
                {
                    nodeTruoc = nodeRun;
                    if (hk.CMND.CompareTo(nodeRun.CMND) < 0)
                    {
                        nodeRun = nodeRun.left;
                    }
                    else if (hk.CMND.CompareTo(nodeRun.CMND) > 0)
                    {
                        nodeRun = nodeRun.right;
                    }
                    else if (hk.CMND.CompareTo(nodeRun.CMND) == 0)
                    {
                        return;
                    }
                }

                if (hk.CMND.CompareTo(nodeTruoc.CMND) > 0)
                {
                    nodeTruoc.right = hk;
                }
                else nodeTruoc.left = hk;
            }
            return;
        }

        /*public static bool delete(string CMND)
        {
            HanhKhach p = root;
            HanhKhach pp = null;
            while (p != null && p.CMND != CMND)
            {
                pp = p;
                if (CMND.CompareTo(p.CMND) < 0)
                    p = p.left;
                else
                    p = p.right;
            }
            if (p == null)
                return false;
            if (p.left != null && p.right != null)
            {
                HanhKhach s = p.left;
                HanhKhach ps = p;
                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                p.CMND = s.CMND;
                p = s;
                pp = ps;
            }
            HanhKhach c = null;
            if (p.left != null)
                c = p.left;
            else
                c = p.right;
            if (p == root)
                root = null;
            else
            {
                if (p == pp.left)
                    pp.left = c;
                else
                    pp.right = c;
            }

            return true;
        }*/
        public static HanhKhach search(string cmnd)
        {
            if (!isItExsit(root, cmnd))
            {
                return null;
            }
            HanhKhach NodeRun = root;
            while (NodeRun != null && (cmnd.CompareTo(NodeRun.CMND) != 0))
            {
                if (cmnd.CompareTo(NodeRun.CMND) > 0)
                    NodeRun = NodeRun.right;
                else
                    NodeRun = NodeRun.left;
            }
            return NodeRun;
        }
        public static bool isItExsit(HanhKhach temproot, string cmnd)
        {
            if (temproot != null)
            {
                if (cmnd.CompareTo(temproot.CMND) == 0)
                    return true;
                else if (cmnd.CompareTo(temproot.CMND) < 0)
                    return isItExsit(temproot.left, cmnd);
                else if (cmnd.CompareTo(temproot.CMND) > 0)
                    return isItExsit(temproot.right, cmnd);
            }
            return false;
        }
        public static void EditDataHK(HanhKhach hkcu, HanhKhach hkmoi)
        {
            HanhKhach NodeRun = root;
            while (NodeRun != null && (hkcu.CMND.CompareTo(NodeRun.CMND) != 0))
            {
                if (hkcu.CMND.CompareTo(NodeRun.CMND) > 0)
                    NodeRun = NodeRun.right;
                else
                    NodeRun = NodeRun.left;
            }
            NodeRun.Ten = hkmoi.Ten;
            NodeRun.Ho = hkmoi.Ho;
            NodeRun.Phai = hkmoi.Phai;
        }

        public static void LuuDanhSachHanhKhachVaoFile(HanhKhach root)
        {
            using (StreamWriter writer = new StreamWriter("..\\data_HK.txt"))
            {
                HanhKhach current = root;

                while (current != null)
                {
                    if (current.left == null)
                    {
                        string CMND = current.CMND.Trim();
                        string Ho = current.Ho.Trim();
                        string Ten = current.Ten.Trim();
                        string Phai = current.Phai.Trim();
                        string line = CMND + ";" + Ho + ";" + Ten + ";" + Phai;
                        writer.WriteLine(line);
                        current = current.right;
                    }
                    else
                    {
                        HanhKhach prev = current.left;

                        while (prev.right != null && prev.right != current)
                        {
                            prev = prev.right;
                        }

                        if (prev.right == null)
                        {
                            prev.right = current;
                            current = current.left;
                        }
                        else
                        {
                            string CMND = current.CMND.Trim();
                            string Ho = current.Ho.Trim();
                            string Ten = current.Ten.Trim();
                            string Phai = current.Phai.Trim();
                            string line = CMND + ";" + Ho + ";" + Ten + ";" + Phai;
                            writer.WriteLine(line);
                            prev.right = null;
                            current = current.right;
                        }
                    }
                }
            }
        }
    }
}
