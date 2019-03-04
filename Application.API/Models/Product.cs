using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.API.Models
{
    public class Product
    {
        /// <summary>
        /// The id of the product
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        /// <example>nodejs</example>
        public string Name { get; set; }

        /// <summary>
        /// The description of the product
        /// </summary>
        /// <example>fantasic language</example>
        public string Description { get; set; }
    }
}
