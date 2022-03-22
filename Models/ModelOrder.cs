using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrm.Models
{
    /// <summary>
    /// Заказы услуги
    /// </summary>
    public class ModelOrder
    {
        /// <summary>
        /// Индетификатор пациента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя пациента
        /// </summary>
        public string Patient { get; set; }

        /// <summary>
        /// Название услуги
        /// </summary>
        public string Servise { get; set; }

        /// <summary>
        /// Дата заказа 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Имя доктра 
        /// </summary>
        public string Doctor { get; set; }

        /// <summary>
        /// Проплачен заказ илм нет 
        /// </summary>
        public string Paid { get; set; }

        /// <summary>
        /// Статус закакза 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Цена заказа
        /// </summary>
        public int Price { get; set; }


    }
}
