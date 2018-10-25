using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    /// <summary>
    /// Результаты проверки
    /// </summary>
    public class ErrorChecking
    {
        /// <summary>
        /// Результаты проверки
        /// </summary>
        public ErrorChecking() { QueueError = new Queue<Error>(); }

        /// <summary>
        /// Список обнаруженых ошибок
        /// </summary>
        public Queue<Error> QueueError { get; set; }

        public void AddQueueError(ErrorChecking errorChecking)
        {
            if (errorChecking.Check)
            {
                while (errorChecking.QueueError.Count != 0)
                { QueueError.Enqueue(errorChecking.QueueError.Dequeue()); }
                Check = errorChecking.Check;
            }
        }

        public bool Check { get; set; }

        /// <summary>
        /// Фиксация ошибки
        /// </summary>
        /// <param name="odjNameSet"> Источник ошибки</param>
        /// <param name="errorTextSet"> Описание ошибки</param>
        public void ErrorSet(string OdjName, string ErrorText)
        { QueueError.Enqueue(new Сheck.Error(OdjName, ErrorText)); Check = true; }

        public void ErrorSet(object obj, string ErrorText)
        { QueueError.Enqueue(new Сheck.Error(obj.GetType().ToString(), ErrorText)); Check = true; }

        /// <summary>
        /// Проверка на заполненость и длину текстового значения
        /// </summary>
        protected void StringCheckNotNullLimitLength(string FieldInfoName, object obj, int limitLength)
        {
            Type typeo = obj.GetType();
            PropertyInfo fieldInfo = typeo.GetProperty(FieldInfoName);
            string text = fieldInfo.GetValue(obj).ToString();
            StringCheckNotNullLimitLength(FieldInfoName, obj, text, limitLength);
        }

        /// <summary>
        /// Проверка на заполненость и длину текстового значения
        /// </summary>
        protected void StringCheckNotNullLimitLength(string FieldInfoName, object obj, string text, int limitLength)
        {
            Type typeo = obj.GetType();
            PropertyInfo fieldInfo = typeo.GetProperty(FieldInfoName);
            string type = obj.GetType().ToString() + "." + FieldInfoName;

            if (string.IsNullOrWhiteSpace(text))
            {
                ErrorSet(
                  type,
                 FieldInfoName + " Не должен быть пустым.");
            }
            StringCheckLimitLength(FieldInfoName, obj, text, limitLength);
        }

        /// <summary>
        /// Проверка на заполненость и длину текстового значения
        /// </summary>
        protected void StringCheckLimitLength(string FieldInfoName, object obj, int limitLength)
        {
            Type typeo = obj.GetType();
            PropertyInfo fieldInfo = typeo.GetProperty(FieldInfoName);
            string text = fieldInfo.GetValue(obj).ToString();

            StringCheckLimitLength(FieldInfoName, obj, text, limitLength);

        }

        /// <summary>
        /// Проверка на заполненость и длину текстового значения
        /// </summary>
        protected void StringCheckLimitLength(string FieldInfoName, object obj, string text, int limitLength)
        {
            Type typeo = obj.GetType();
            PropertyInfo fieldInfo = typeo.GetProperty(FieldInfoName);
            string type = obj.GetType().ToString() + "." + FieldInfoName;

            if (text.Length > limitLength)
            {
                ErrorSet(
                  type,
                 String.Format("{0} максимум {1} символов. Факт {2} знаков: {3}", FieldInfoName, limitLength.ToString(), text.Length.ToString(), text));
            }
        }
    }

    /// <summary>
    /// Обнаруженая ошибка
    /// </summary>
    public struct Error
    {
        string odjName, errorText;
        DateTime dateTime;
        /// <summary>
        /// Фиксация ошибки
        /// </summary>
        /// <param name="odjNameSet"> Источник ошибки</param>
        /// <param name="errorTextSet">Описание ошибки</param>
        public Error(string odjNameSet, string errorTextSet)
        {
            odjName = odjNameSet;
            errorText = errorTextSet;
            dateTime = DateTime.Now;
        }

        /// <summary>
        /// Источник ошибки
        /// </summary>
        public string OdjName { get { return odjName; } }

        /// <summary>
        /// Описание ошибки
        /// </summary>
        public string ErrorText { get { return errorText; } }

        /// <summary>
        /// Дата фиксации ошибки
        /// </summary>
        public DateTime Date { get { return dateTime; } }

    }
}
