using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonLibrary.Enums;

namespace CommonLibrary.Models
{
    public abstract class Model : IModel
    {
        private int id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        [DataType(DataType.Text)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime? createdDate;
        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public DateTime? modefiedDate;
        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        public DateTime? ModefiedDate
        {
            get { return modefiedDate; }
            set { modefiedDate = value; }
        }

        private State state;
        [Column(TypeName = "state")]
        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
