
// int[] nilai = new int [5]; 
// nilai[0] = 80;
// nilai[1] = 60;
// nilai[2] = 75;
// nilai[3] = 100;
// nilai[4] = 40;

// for (int i = 0; i< 5; i++) {
//     Console.WriteLine($"Nilai ke-{i+1}:{nilai[i]}");
// }






//------------------------------------------------------------------------------------
//Latihan Praktikum nomer 1 

// // 2 array satu dimensi 
// string[] namaBarang = { "Indomie Goreng", "Kacang Sukro", "Chiki Balls", "Teh Kotak", "Susu Naga" };
// int[] stokBarang = { 50, 40, 40, 0, 0 };

// //stok barang stok teh kotak 20 dan susu naga 30 
// stokBarang[3] += 40;
// stokBarang[4] += 40;

// // menampilkan nama dan stok barang
// for (int i = 0; i < namaBarang.Length; i++) {
//     Console.WriteLine($"Nama Barang : {namaBarang[i]}, Stok Barang : {stokBarang[i]}");
// }

// //barang dengan stok dibawah 30 
// bool stoktipis = false;
// Console.WriteLine("Barang dengan stok dibawah 30 :");
// for (int i = 0; i < stokBarang.Length; i++) {
//     if (stokBarang[i] < 30) 
//     {
//         Console.WriteLine($"{namaBarang[i]} - Stok: {stokBarang[i]}");
//         stoktipis = true;
//     }
// }

// if (!stoktipis)
// {
//     Console.WriteLine("Stok aman");
// }
//------------------------------------------------------------------------------------
//Latihan Praktikum nomer 2

// Array dua dimensi pengiriman barang
int[,] pengirimanBarang = new int[,]
{
    { 100, 120, 110, 105, 115 },
    { 80, 75, 85, 90, 100 },
    { 150, 140, 130, 135, 145 }
};

string[] namaBarang = 
{
    {"Indomie Goreng"}, 
    {"Kacang Sukro"}, 
    {"Chiki Balls"}, 
    {"Teh Kotak"}, 
    {"Susu Naga"} 
};

// // menghitung total pengiriman selama 5 hari 
// int[] totalPengiriman = new int[pengirimanBarang.GetLength(0)];
// for (int i = 0; i < pengirimanBarang.GetLength(0); i++)
// {
//     for (int j = 0; j < pengirimanBarang.GetLength(1); j++)
//     {
//         totalPengiriman[i] += pengirimanBarang[i, j];
//     }
// }

// // menghitung rata-rata total pengiriman barang
// for (int i = 0; i < totalPengiriman.Length; i++) {
//     Console.WriteLine($"Total pengiriman untuk produk {(char)('A' + i)}: {totalPengiriman[i]}");
//     Console.WriteLine($"Rata-rata pengiriman untuk produk {(char)('A' + i)}: {(float)totalPengiriman[i] / pengirimanBarang.GetLength(1)}");
// }
