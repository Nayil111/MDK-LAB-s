namespace ������������_������__2
{
    class Program
    {
        // ������� 1
        static void Main(string[] args)
        {
            Console.WriteLine("������� �����");
            int number = 0;
            while (true)
            {
                string str = Console.ReadLine();
                bool res = int.TryParse(str, out number);
                if (res == true)
                {
                    if ((number >= 1) && (number <= 7))

                    {

                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("�����������");
                                break;
                            case 2:
                                Console.WriteLine("�������");
                                break;
                            case 3:
                                Console.WriteLine("�����");
                                break;
                            case 4:
                                Console.WriteLine("�������");
                                break;
                            case 5:
                                Console.WriteLine("�������");
                                break;
                            case 6:
                                Console.WriteLine("�������");
                                break;
                            case 7:
                                Console.WriteLine("�����������");
                                break;
                        }
                        if (number == 1)
                        {
                            Console.WriteLine("�����������");
                        }
                        if (number == 2)
                        {
                            Console.WriteLine("�������");
                        }
                        if (number == 3)
                        {
                            Console.WriteLine("�����");
                        }
                        if (number == 4)
                        {
                            Console.WriteLine("�������");
                        }
                        if (number == 5)
                        {
                            Console.WriteLine("�������");
                        }
                        if (number == 6)
                        {
                            Console.WriteLine("�������");
                        }
                        if (number == 7)
                        {
                            Console.WriteLine("�����������");
                        }
                    }
                    else Console.WriteLine("������");

                }
                else Console.WriteLine("������");

                // ������� 2
                Console.WriteLine("������� �����");
                int num = 10;
                if ((num % 3 == 0) && (num % 5 == 0))
                {
                    Console.WriteLine("BuzzFizz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // ������� 3

                Console.ReadLine();

                Console.WriteLine("��");
            }





        }
    }
}
