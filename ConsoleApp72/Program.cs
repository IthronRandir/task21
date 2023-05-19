class Program
{
    static void Main(string[] args)
    {
        double ax1 = -3;
        double ay1 = 0;
        double ax2 = 3;
        double ay2 = 4;

        double bx1 = 0;
        double by1 = -1;
        double bx2 = 9;
        double by2 = 2;

        double Left = Math.Abs(ax1 - bx1);
        double Right = Math.Abs(ax2 - bx2);
        double totalWidth1 = Math.Abs(ax1 - bx2);
        double totalWidth2 = Math.Abs(ax2 - bx1);
        double widthIntersect = Math.Max(totalWidth1, totalWidth2) - Left - Right;

        double top = Math.Abs(ay2 - by2);
        double bottom = Math.Abs(ay1 - by1);
        double totalHeight1 = Math.Abs(ay2 - by1);
        double totalHeight2 = Math.Abs(ay1 - by2);
        double heightIntersect = Math.Max(totalHeight1, totalHeight2) - top - bottom;

        double intersectArea = widthIntersect * heightIntersect;
        
        double width1 = Math.Abs(ax1 - ax2);
        double width2 = Math.Abs(bx1 - bx2);
        double height1 = Math.Abs(ay1 - ay2);
        double height2 = Math.Abs(by1 - by2);

        double area1 = width1 * height1;
        double area2 = width2 * height2;
        double unionArea = area1 + area2 - intersectArea;

        Console.WriteLine(unionArea);
    }
}