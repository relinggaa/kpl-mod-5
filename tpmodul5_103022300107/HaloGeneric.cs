using System;

namespace tpmodul5_103022300107
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}!");
        }

        //static void Main(string[] args)
        //{
        //    HaloGeneric halo = new HaloGeneric();

        //    string namaPengguna = "Relingga";
        //    halo.SapaUser(namaPengguna);

        //    Console.ReadLine();
        //}
    }
}
