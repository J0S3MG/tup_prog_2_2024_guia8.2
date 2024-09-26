´´´csharp
  DateTime fechaPlan = DateTime.Today;//20-12-2024

  //mes siguiente 
  DateTime siguiente = fechaPlan.AddMonth(1); //20-01-2024

  //Dia 1 del mes siguiente
  siguiente = new DateTime(siguiente.Year,siguiente.Month,1);
  siguiente.AddDays(4);

  //5to dia habil
  int diahabil = 1;
´´´