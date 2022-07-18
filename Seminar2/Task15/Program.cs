Console.Write("Введите порядковый номер дня недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

  if (Number == 6 || Number == 7) {
  Console.WriteLine("этот день выходной ");
  }
  else if (Number < 1 || Number > 7) {
    Console.WriteLine("Это не день недели ");
  }
  else{
  Console.WriteLine("этот день не выходной ");
  }
