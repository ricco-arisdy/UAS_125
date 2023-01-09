using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_125
{
    class node
    {
        public int noBuku;
        public string judulBuku;
        public int jumlah;
        public int tanggal;
        public node next;
        
    }
    class Circular
    {
        node LAST;

        public Circular()
        {
            LAST = null;
        }
        public void addnode()
        {
            int nobuku;
            string nm;
            Console.Write("\nEnter No Buku: ");
            nobuku = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter nama buku: ");
            nm = Console.ReadLine();
            node newNode = new node();
            newNode.noBuku = nobuku;
            newNode.judulBuku = nm;
        }

        public bool Search(int rollNo, ref node previous, ref node current)
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.noBuku)
                    return (true);
            }
            if (rollNo == LAST.noBuku)
                return true;
            else
                return (false);
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
            {
                Console.WriteLine("\nRecord in the list are: \n");
                node currentnode;
                currentnode = LAST.next;
                while (currentnode != LAST)
                {
                    Console.WriteLine(currentnode.noBuku + " " +
                        currentnode.judulBuku + "\n");
                    currentnode = currentnode.next;
                }
          
            }
        }
        public void firstnode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
                Console.WriteLine("\nThe frist record in the list:\n" +
                    LAST.next.noBuku + " " + LAST.next.judulBuku);
        }
        static void Main(string[] args)
        {
            Circular obj = new Circular();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("\n1. Mengurutkan Data");
                    Console.WriteLine("\n2. Mencari Data ");
                    Console.WriteLine("\n3. Menampilkan");
                    Console.WriteLine("\n4. exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is Empty");
                                    break;
                                }
                                node prev, curr;
                                prev = curr = null;
                                Console.WriteLine("\nEnter the nomor buku is to be search: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref prev, ref curr) == false)
                                    Console.WriteLine("\nRecord not found");
                                else
                                {
                                    Console.WriteLine("\nRecod found");
                                    Console.WriteLine("\nNomer buku: " + curr.noBuku);
                                    Console.WriteLine("\nJudul buku: " + curr.judulBuku);
                                }
                            }
                            break;
                        case '3':
                            {
                                obj.firstnode();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}

//2. circular
//3. Push and Pop
//4. front and rear
//5. a. 3
//   b. postrder anak tiri ke kanan habis itu orang tua ke atas
