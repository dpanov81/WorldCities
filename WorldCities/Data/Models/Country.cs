using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data.Models
{
    public class Country
    {
        public Country()
        {

        }

        /// <summary>
        /// Уникальный идентификатор и первичный ключ страны.
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Название страны (в формате UTF8).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код страны (в формате ISO 3166-1 ALPHA-2).
        /// </summary>
        public string ISO2 { get; set; }

        /// <summary>
        /// Код страны (в формате ISO 3166-1 ALPHA-3).
        /// </summary>
        public string ISO3 { get; set; }

        /// <summary>
        /// Список, содержащий все города, относящиеся к этой стране.
        /// </summary>
        public virtual List<City> Cities { get; set; }
    }
}
