namespace modifi
{
     class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }


        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        public Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}