namespace ExpensesAPI
{
    public static class TypesTools
    {
        public static string GetMonthAsString(Month month) => month switch
        {
            Month.JANUARY   => "January",
            Month.FEBRUARY  => "February",
            Month.MARCH     => "March",
            Month.APRIL     => "April",
            Month.MAY       => "May",
            Month.JUNE      => "June",
            Month.JULY      => "July",
            Month.AUGUST    => "August",
            Month.SEPTEMBER => "September",
            Month.OCTOBER   => "October",
            Month.NOVEMBER  => "November",
            Month.DECEMBER  => "December",
            _               => throw new ArgumentException("Error in GetMonthAsString function argument.")
        };
    }

    public enum Month
    {
        JANUARY = 1,
        FEBRUARY = 2,
        MARCH = 3,
        APRIL = 4,
        MAY = 5,
        JUNE = 6,
        JULY = 7,
        AUGUST = 8,
        SEPTEMBER = 9,
        OCTOBER = 10,
        NOVEMBER = 11,
        DECEMBER = 12,
    }
}
