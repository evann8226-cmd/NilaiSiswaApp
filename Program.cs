int nilai;
string nama;

Console.WriteLine("Aplikasi Nili Siswa");

Console.Write("Input Nama: ");
nama = Console.ReadLine();

Console.Write("IInput NIlai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("Selamat, Anda Lulus!");
else
    Console.WriteLine("Maaf,Anda Belum Lulus!");