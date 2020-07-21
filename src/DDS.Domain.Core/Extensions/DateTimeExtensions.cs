using System;

namespace DDS.Domain.Core.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Retorna a data contida na variável ou <see cref="DateTime.MinValue"/>, caso a variável contenha null
        /// </summary>
        public static DateTime GetValueOrMin(this DateTime? dataHora) => dataHora.GetValueOrDefault(DateTime.MinValue);

        /// <summary>
        /// Retorna a data contida na variável ou <see cref="DateTime.MaxValue"/>, caso a variável contenha null
        /// </summary>
        public static DateTime GetValueOrMax(this DateTime? dataHora) => dataHora.GetValueOrDefault(DateTime.MaxValue);
    }
}
