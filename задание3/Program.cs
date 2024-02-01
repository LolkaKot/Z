// ====================================
Console.WriteLine("Задание №1");

double L1, e1, x1, a1, g1, c1;

Console.WriteLine("Введите значение перременной e");
e1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной a");
a1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной g");
g1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной c");
c1 = Convert.ToDouble(Console.ReadLine());

L1 = (Math.Sqrt(Math.Pow(e1,x1)-Math.Pow((Math.Cos(Math.Pow(x1,2)*Math.Pow(a1,5))),4)))+Math.Pow((Math.Atanh(a1-Math.Pow(x1,5))),4)/(Math.Pow((Math.Abs(a1+x1*Math.Pow(c1,4))), e1/2));

Console.WriteLine($"Результат задания №1 = {L1}");


// ====================================
Console.WriteLine("Задание №2");

double L2, c2, x2, t2;

Console.WriteLine("Введите значение перременной c");
c2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной t");
t2 = Convert.ToDouble(Console.ReadLine());


L2 = Math.Pow((Math.Tanh(c2)),2)*((2*Math.Pow(x2,2)+5))/(Math.Sqrt(c2+t2));

Console.WriteLine($"Результат задания №2 = {L2}");


// ====================================
Console.WriteLine("Задание №3");

double A3, y3, h3;

Console.WriteLine("Введите значение перременной y");
y3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной h");
h3 = Convert.ToDouble(Console.ReadLine());

A3 = (Math.Tan(Math.Pow(y3,3)-Math.Pow(h3,4))+Math.Pow(h3,2))/(Math.Pow((Math.Sin(h3)),3)+y3);

Console.WriteLine($"Результат задания №3 = {A3}");


// ====================================
// ====================================
Console.WriteLine("Задание №4");

double F4, y4, x4;

Console.WriteLine("Введите значение перременной e");
y4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x4 = Convert.ToDouble(Console.ReadLine());
F4 = (Math.Sqrt(Math.Pow((2+y4),2)+Math.Pow((Math.Sin(y4+5)),7/2)))/(Math.Log(x4+1)-Math.Pow(y4,3));

Console.WriteLine($"Результат задания №4 = {F4}");


// ====================================
// ====================================
Console.WriteLine("Задание 5");

double G5, x5, z5, y5, c5;

Console.WriteLine("Введите значение перременной z");
z5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной y");
y5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной c");
c5 = Convert.ToDouble(Console.ReadLine());


G5 = (Math.Tan(Math.Pow(x5,4)-6)-Math.Pow((Math.Cos(z5+x5*y5)),3))/(Math.Pow((Math.Cos(Math.Pow(x5,3)*Math.Pow(c5,2))),4));

Console.WriteLine($"Результат задания №5 = {G5}");


// ====================================
// ====================================
Console.WriteLine("Задание №6");

double K6, x6, b6, a6, y6;

Console.WriteLine("Введите значение перременной x");
x6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной b");
b6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной a");
a6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной y");
y6 = Convert.ToDouble(Console.ReadLine());


K6 = (Math.Sqrt(x6+b6-a6)+Math.Log(y6))/(Math.Atan(b6+a6));

Console.WriteLine($"Результат задания №6 = {K6}");


// ====================================
// ====================================
Console.WriteLine("Задание №7");

double D7, y7, x7, a7;

Console.WriteLine("Введите значение перременной y");
y7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной a");
a7 = Convert.ToDouble(Console.ReadLine());


D7 = (Math.Cos(Math.Pow(x7,3)+6)-Math.Sin(y7-a7))/(Math.Log(Math.Pow(x7,4))-2*Math.Pow(Math.Sin(x7),5));

Console.WriteLine($"Результат задания №7 = {D7}");


// ====================================
// ====================================
Console.WriteLine("Задание №8");

double P8, y8, x8, c8,a8;

Console.WriteLine("Введите значение перременной y");
y8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной c");
c8 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной a");
a8 = Convert.ToDouble(Console.ReadLine());


P8 = (Math.Pow(a8,5)+Math.Pow((Math.Sin(y8-c8)),4))/(Math.Pow((Math.Sin(x8+y8)),3)+Math.Abs(x8-y8));

Console.WriteLine($"Результат задания №8 = {P8}");


// ====================================
// ====================================
Console.WriteLine("Задание №9");

double R9, y9, x9, d9, e9;

Console.WriteLine("Введите значение перременной e");
e9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной y");
y9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной d");
d9 = Convert.ToDouble(Console.ReadLine());


R9 = (Math.Pow((Math.Cos(y9)),3)+Math.Pow(2,x9)*d9)/(Math.Pow(e9,x9)+Math.Log(Math.Pow((Math.Sin(x9)),2)+7.4));

Console.WriteLine($"Результат задания №9 = {R9}");


// ====================================
// ====================================
Console.WriteLine("Задание №10");

double U10, e10, x10, y10;

Console.WriteLine("Введите значение перременной e");
e10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной y");
y10 = Convert.ToDouble(Console.ReadLine());


U10 = (Math.Pow(e10,Math.Pow(x10,3))+Math.Pow((Math.Cos(x10-4)),2))/(Math.Atan(10)+5.2*y10);

Console.WriteLine($"Результат задания №10 = {U10}");


// ====================================
// ====================================
Console.WriteLine("Задание №11");

double I11, y11, x11, e11;

Console.WriteLine("Введите значение перременной e");
e11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной y");
y11 = Convert.ToDouble(Console.ReadLine());

I11 = (2.33*Math.Log(Math.Sqrt(1+Math.Pow((Math.Cos(y11)),2))))/(Math.Pow(e11,y11)+Math.Pow((Math.Sin(x11)),2));

Console.WriteLine($"Результат задания №11 = {I11}");


// ====================================// ====================================
Console.WriteLine("Задание №12");

double G12, y12, x12, a12;

Console.WriteLine("Введите значение перременной y");
y12 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x12 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной a");
a12 = Convert.ToDouble(Console.ReadLine());


G12 = (Math.Pow((Math.Cos(Math.Abs(y12+x12))),3)-(x12+y12))/(Math.Pow((Math.Atan(x12+a12)),4)*Math.Pow(x12,3));

Console.WriteLine($"Результат задания №12 = {G12}");


// ====================================
// ====================================
Console.WriteLine("Задание №13");

double R13, b13, x13, a13;

Console.WriteLine("Введите значение перременной b");
b13 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной x");
x13 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной a");
a13 = Convert.ToDouble(Console.ReadLine());

R13 = ((a13)/(x13-a13))+((Math.Pow(b13,x13)+Math.Pow((Math.Cos(x13)),3))/(Math.Pow((Math.Log(a13)),3)+4.5));

Console.WriteLine($"Результат задания №13 = {R13}");


// ====================================
// ====================================
Console.WriteLine("Задание №14");

double R14, x14;


Console.WriteLine("Введите значение перременной x");
x14 = Convert.ToDouble(Console.ReadLine());

R14 = (Math.Sin(Math.Pow(((Math.Pow(x14,2))+4),3))+4.3)/(Math.Pow((Math.Cos(Math.Pow(x14,4))),3));

Console.WriteLine($"Результат задания №14 = {A3}");


// ====================================
// ====================================
Console.WriteLine("Задание №15");

double N15, y15, m15;

Console.WriteLine("Введите значение перременной y");
y15 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение перременной m");
m15 = Convert.ToDouble(Console.ReadLine());

N15 = (Math.Pow(m15,2)+2.8*m15+0.355)/(Math.Cos(2)*y15+3.6);

Console.WriteLine($"Результат задания №15 = {N15}");


// ====================================
