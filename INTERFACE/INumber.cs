namespace INTERFACE
{
    interface INumber
    {
        public int num { get; set; }
        INumber Add(INumber n);
        INumber Sub(INumber n);
        int CompareTo(INumber n);
    }
}
