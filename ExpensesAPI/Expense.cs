namespace ExpensesAPI
{
    public class Expense
    {
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ExpenseTypeid { get; set; }
        public float Sum { get; set; }
        public int Year { get; set; }
        public Month Month { get; set; }
    }

   
}
