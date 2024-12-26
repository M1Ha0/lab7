Rabotnik[] rabotniks = new Rabotnik[3];
for (int i = 0; i < rabotniks.Length; i++)
{
    Console.Write("Введите фамилию сотрудника:");
    string fio = Console.ReadLine();
    Console.Write("Введите должность сотрудника:");
    string post = Console.ReadLine();
    Console.Write("Введите оклад:");
    double oklad = double.Parse(Console.ReadLine());
    Console.Write("Дата окончания контракта:");
    DateTime td = DateTime.Parse(Console.ReadLine());
    Console.Write("Дата подписания контракта:");
    DateTime rd = DateTime.Parse(Console.ReadLine());
    Rabotnik rabotnik = new Rabotnik(fio, post, oklad, td, rd);
    rabotniks[i] = rabotnik;
}
foreach (Rabotnik rabotnik in rabotniks)
{
    if (DateTime.Now.Subtract(rabotnik.SignDate).TotalDays < 365)
        rabotnik.Print();
}

struct Rabotnik
{
    public string Fio;
    public string Post;
    public double Oklad;
    public DateTime LastDate;
    public DateTime SignDate;
    public Rabotnik(string fio, string post, double oklad, DateTime lastDate, DateTime signDate)
    {
        Fio = fio;
        Post = post;
        Oklad = oklad;
        LastDate = lastDate;
        SignDate = signDate;
    }
    public void Print()
    {
        Console.WriteLine($"Фамилия работника:{Fio} " +
                          $"Должность:{Post} " +
                          $"Дата окончания контракта:{LastDate} " +
                          $"Оклад:{Oklad}" +
                          $"Дата подписания контракта:{SignDate}");
    }
}