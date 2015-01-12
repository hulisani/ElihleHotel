using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Monitor.Entities
{
    public class Expense : Notifier
    {
        private int id;
        [Key]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                RaisePropertyChanged("Id");
            }
        }

        private string reasonForExpense;
        public string ReasonExpense
        {
            get
            {
                return reasonForExpense;
            }
            set
            {
                reasonForExpense = value;
                RaisePropertyChanged("ReasonExpense");
            }
        }

        private decimal amount;
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                RaisePropertyChanged("Amount");
            }
        }

        private Employee employee;
        public virtual Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                RaisePropertyChanged("Employee");
            }
        }


    }
}
