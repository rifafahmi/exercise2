using System;

namespace exercise2
{
    class Program
    {
        // Deklarasi array int dengan ukuran 51+20-2x15+10+20 = 71
        private int[] rifa = new int[71];
        // Deklarasi variabel int untuk menyimpan banyaknya data pada array 
        private int n;
        // Fungsi / Method untuk menerima masukan 
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 71)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 71 elemen.\n");
                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine(" Masukkan elemen array ");
                Console.WriteLine("------------------------");
                // Pengguna memasukkan elemen pada array
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("<" + (i + 1) + "> ");
                    string s1 = Console.ReadLine();
                    rifa[i] = Int32.Parse(s1);
                }
            }
        }

        private void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("------------ -----------------------");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("-----------------------------------");
            for (int rf = 0; rf < n; rf++)
            {
                Console.WriteLine(rifa[rf]++);
            }
            Console.WriteLine("");
        }

        public void BubleSortArray()
        {
            for (int i = 1; i < n; i++) // for n-1 passes
            {
                // Pada pass i , bandingkan n - i elemen pertama dengan elemen selanjutnya 
                for (int rf = 0; rf < n - i; rf++)
                {
                    if (rifa[rf] > rifa[rf + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = rifa[rf];
                        rifa[rf] = rifa[rf + 1];
                        rifa[rf + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating the object of the Bubblesort class 
            Program myList = new Program();
            // Pemanggilan fungsi untuk menerima elemen array 
            myList.read();
            // Pemanggilan fungsi untuk menampilkan array 
            myList.BubleSortArray();
            //manggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
            Console.Read();

        }
    }
}


namespace QuickShort
{
    class Program
    {
        //array of integers to hold value
        private int[] rifa = new int[71];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements

        //number of elements in array
        private int n;
        private int pivot;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 71)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 71 elements \n");

            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=======================");

            //get array elements 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                rifa[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index y

        void swap(int x, int y)
        {
            int temp;
            temp = rifa[x];
            rifa[x] = rifa[y];
            rifa[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int i, rf, k;
            if (low >= high)
                return;
            int mid = (low + high / 2);

            //Partition the list into two parts:
            // one containing elements less that or equal to pivot
            //Outher containning elements greather than pivot

            i = low;
            rf = mid + 1;
            k = low;

            //Partition the list into two parts:
            // one containing elements less that or equal to pivot
            //Outher containning elements greather than pivot

            i = low + 1;
            rf = high;

            pivot = rifa[low];
            while (i <= rf)
            {
                //search for an element greater than pivot
                while ((rifa[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //search for an element less than equal to pivot
                while
                     ((rifa[rf] > pivot) && (rf >= low))
                {
                    rf--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < rf) //if the greater element is on the left of the element
                {
                    //swap the element at index i whit the element at index rf
                    swap(i, rf);
                    mov_count++;

                }
            }
            // rf now contains the index of the last element in the sorted list

            if (low < rf)
            {
                //Move the pivot to its correct posituon in the list
                swap(low, rf);
                mov_count++;
            }
            // sort the list on the left of pivot uisng quick sort
            q_sort(low, rf - 1);

            //Sort the list on the right of pivot using quick sort
            q_sort(rf + 1, high);

        }

        void display()
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine(" Sorted array Elements");
            Console.WriteLine("----------------------");

            for (int rf = 0; rf < n; rf++)
            {
                Console.WriteLine(rifa[rf]);
            }
            Console.WriteLine("\nNumber Of Comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movemenet: " + mov_count);
        }

        int getSize()
        {
            return (n);
        }
        static void Main(String[] args)
        {
            //Declaring the object of the class
            Program myList = new Program();
            //Acept Array elements
            myList.read();
            //calling the sorting function
            //frist call to quick sort Algorithm
            myList.q_sort(0, myList.getSize() - 1);
            //display sorted array
            myList.display();
            //to exit from the console
            Console.WriteLine("\n\nPress enter to exit.");
            Console.Read();
        }
    }
}
