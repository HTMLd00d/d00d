// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//число, которое нужно возвести в степень
  Console.Write("Введите число A  : ");
  int num = int.Parse(Console.ReadLine());
  Console.Write("Введите число B : ");
  int degree = int.Parse(Console.ReadLine());
  int ndegree =1;
  for(int i=0; i<degree; i++) {
   ndegree*=num;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num, degree, ndegree);
  Console.ReadKey();