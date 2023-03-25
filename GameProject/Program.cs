namespace GameProject
{0
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer admin = new Gamer { FisrtName = "Admin", LastName = "Abc", DateOfBirth = new DateTime(1993), Id = 1, IdentityNumber = "1554694964", NickName = "Amasraa74" };
            gamerManager.Add(new Gamer { FisrtName = "Akif", LastName = "Bilgin", DateOfBirth = new DateTime(1993) });
            gamerManager.Update(admin);

        }
    }
}