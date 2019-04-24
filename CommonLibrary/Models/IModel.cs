using CommonLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary.Models
{
    public interface IModel
    {
        int Id { get; set; }

        string Name { get; set; }
        DateTime? CreatedDate { get; set; }

        DateTime? ModefiedDate { get; set; }

        State State { get; set; }
    }
}
