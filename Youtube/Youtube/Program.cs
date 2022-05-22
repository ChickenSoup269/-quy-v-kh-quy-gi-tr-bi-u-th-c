
// Hàm đệ quy
static float Dequy(float n)
{
    float s = 0;
    for(int i = 1; i <= n; i++)
    {
        s = (float)Math.Sqrt(2 + s);
    }
    return s;
}

// Hàm khử đệ quy
static float KhuDequy(float n)
{
    if (n < 2)
    {
        return (float)Math.Sqrt(2);
    }
    return (float)Math.Sqrt(2 + KhuDequy(n - 1));
}
Console.Write("Nhap n: ");
int n =Int32.Parse(Console.ReadLine());

// Kiểm lỗi không cho nhập số âm
while (n < 0)
{
    Console.WriteLine("Khong duoc nhap so am !");
    Console.Write("Vui long nhap lai n: ");
     n = Int32.Parse(Console.ReadLine());

}
Console.WriteLine(" De quy {0}", Dequy(n));
Console.WriteLine(" Khu de quy {0}", KhuDequy(n));

