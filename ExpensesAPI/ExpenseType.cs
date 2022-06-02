using System.ComponentModel.DataAnnotations;

namespace ExpensesAPI
{
    public class ExpenseType
    {
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; } = string.Empty;

    }
}
