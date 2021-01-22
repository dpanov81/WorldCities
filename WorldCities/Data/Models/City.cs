using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data.Models
{
    public class City
    {
        public City()
        {

        }
        /// <summary>
        /// Уникальный идентификатор и первичный ключ для этого города.
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Название города (в формате UTF8).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Название города (в формате ASCII).
        /// </summary>
        public string Name_ASCII { get; set; }

        /// <summary>
        /// Широта города.
        /// </summary>
        public decimal Lat { get; set; }

        /// <summary>
        /// Долгота города.
        /// </summary>
        public decimal Lon { get; set; }

        /// <summary>
        /// Идентификатор страны (внешний ключ).
        /// </summary>
        [ForeignKey("Country")]
        public int CountryId { get; set; }

        /// <summary>
        /// Страна относящаяся к этому городу.
        /// </summary>
        public virtual Country Country { get; set; }
    }
}
