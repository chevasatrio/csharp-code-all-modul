// for (int i = 0, i < 3, i++){
//     for (int j = 0, j < 3, j++){

//     }
// }


// int i,j,angka;
// i = 1
// while (){

// }

//-------------------------------------------------
//LATIHAN PRAKTIKUM 
// for (int i = 1; i <= 5; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.Write($"{i}-{j}\t");
//     }
//     Console.WriteLine();
// }   

//faktorial 3

        //  Console.Write("Masukkan angka: ");
        // int angka = Convert.ToInt32(Console.ReadLine());
        // int n1 = 3;
        // int factorial1 = 1;
        
        // for (int i = 1; i <= n1; i++) 
        // {
        //     factorial1 *= i;
        // }
        // Console.WriteLine($"Faktorial dari {n1}! adalah {factorial1}");

        //----------------------------------------------------------------
        
        // //faktorial 5
        // int n2 = 5;
        // int factorial2 = 1;
        
        // for (int i = 1; i <= n2; i++) 
        // {
        //     factorial2 *= i;
        // }
        // Console.WriteLine($"Faktorial dari {n2}! adalah {factorial2}");


        //-----------------

        //  for (int n = 1; n <= 10; n++)
        // {
        //     int factorial = 1;

        //     for (int i = 1; i <= n; i++)
        //     {
        //         factorial *= i;
        //     }

        //     Console.WriteLine($"Faktorial dari {n}! adalah {factorial}");
        // }

        //---------------------------------------------------------------------------
    //     int i,j;
    //     Console.WriteLine("Masukkan angka pertama :");
    //     i = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Masukkan angka kedua :");
    //     j = Convert.ToInt32(Console.ReadLine());
    
    //    if (i > 10 && j > 100){
    //     Console.WriteLine("i dan j lebih dari 10 dan 100");
    //     }else if (i > 10 && j < 100){
    //         if (i > j){
    //     Console.WriteLine($"Nilai yang lebih besar adalah i: {i}");
    // } else {
    //     Console.WriteLine($"Nilai yang lebih besar adalah j: {j}");
    // }
    // } else {
    // Console.WriteLine("Kondisi lainnya tidak terpenuhi.");
    // }

// int hari,bulan,tahun;
// Console.WriteLine("Masukkan tanggal:");
// hari = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Masukkan Bulan:");
// bulan = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Masukkan Tahun:");
// tahun = Convert.ToInt32(Console.ReadLine());

// if(hari*bulan == tahun){
//     Console.WriteLine("Tahun Ajaib");
// }else {
//     Console.WriteLine("Tahun tidak Ajaib");
// }
            

        // Console.WriteLine("Masukkan angka 0 untuk keluar\n");
        // string pilihan1,pilihan2;

        // while (true)
        //  {
        //     Console.WriteLine("Masukkan Warna Primer 1: ");
        //     pilihan1 = Console.ReadLine().ToLower();
        //     Console.WriteLine("Masukkan Warna Primer 2: ");
        //     pilihan2 = Console.ReadLine().ToLower();

        //     if (pilihan1 == "0" && pilihan2 == "0"){
        //         break;
        //     }

        //     if (pilihan1 == "merah" && pilihan2 == "biru") 
        //     {
        //         Console.WriteLine("Ungu");
        //     }
           
        //     else if (pilihan1 == "merah" && pilihan2 == "kuning") 
        //     {
        //        Console.WriteLine("Orange");
        //     }
       
        //     else if (pilihan == pilihan1 == "biru" && pilihan2 == "kuning") 
        //     {
        //          Console.WriteLine("hijau");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Error! Pilihan tidak valid.");
        //         continue;
        //     }
        //  }
        


        // //---------------------------------------------------------
        // Console.WriteLine("Masukkan angka 0 untuk keluar\n");
        // string pilihan1, pilihan2;

        // while (true)
        // {
        //     Console.WriteLine("Masukkan Warna Primer 1: ");
        //     pilihan1 = Console.ReadLine().ToLower();
        //     Console.WriteLine("Masukkan Warna Primer 2: ");
        //     pilihan2 = Console.ReadLine().ToLower();

        //     if (pilihan1 == "0" && pilihan2 == "0")
        //     {
        //         break;
        //     }

        //     if (pilihan1 == "merah" && pilihan2 == "biru")
        //     {
        //         Console.WriteLine("Ungu");
        //     }
        //     else if (pilihan1 == "merah" && pilihan2 == "kuning")
        //     {
        //         Console.WriteLine("Orange");
        //     }
        //     else if (pilihan1 == "biru" && pilihan2 == "kuning") // Corrected this line
        //     {
        //         Console.WriteLine("Hijau");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Error! Pilihan tidak valid.");
        //         continue;
        //     }
        // }

        // int n = 3;
        // int angka = 0;
        // for(int i = 1; i <= n; i++){

        //     for(int j = 1; j <= i; j++){

        //         Console.Write(i);
        //         angka = angka + 1;

        //     }

        //     Console.WriteLine();

        // }
        // Console.WriteLine("angka yang dicetak",angka);

// int a = 4;

// for(int i = 0; i <= a; i++){

//       Console.Write(i);

// }

// int x = 10;
// int y = 5;
// while (x > y){
//     x = x - 1;
//     Console.WriteLine(x);
// }


// for (int i = 1; i <= 5; i++) {

//     if(i == 3)

//         continue;

//     Console.Write(i + " ");

// }

// double a = 5.5;

// int b = (int) a;

// Console.WriteLine(b);

int x = 15;

int y = 20;

string output;


if (x > y) {

    output = "x is greater than y";

}

else if (x == y) {

    output = "x is equal to y";

}

else {

    output = "x is less than y";

}

Console.WriteLine(output);