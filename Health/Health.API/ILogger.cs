﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Health.API
{
    /// <summary>
    /// Интерфейс для логгера.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Записать сообщение в лог.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <param name="level">Уровень.</param>
        void Log(string message, int level);

        /// <summary>
        /// Записать сообщение трассировки в лог.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        void Trace(string message);

        /// <summary>
        /// Записать сообщение отладки в лог.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        void Debug(string message);

        /// <summary>
        /// Записать информационное сообщение в лог.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        void Info(string message);

        /// <summary>
        /// Записать предупреждающее сообщение в лог.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        void Warn(string message);

        /// <summary>
        /// Записать сообщение об ошибке в лог.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        void Error(string message);

        /// <summary>
        /// Записать критическое сообщение в лог.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        void Fatal(string message);

        /// <summary>
        /// Включено ли логгирование?
        /// </summary>
        /// <param name="level">Уровень.</param>
        /// <returns>Статус.</returns>
        bool IsEnabled(int level);

        /// <summary>
        /// Включен ли лог для сообщений трассировки?
        /// </summary>
        bool IsTraceEnabled { get; }

        /// <summary>
        /// Включен ли лог для сообщений отладки?
        /// </summary>
        bool IsDebugEnabled { get; }

        /// <summary>
        /// Включен ли лог для информационных сообщений?
        /// </summary>
        bool IsInfoEnabled { get; }

        /// <summary>
        /// Включен ли лог для предупреждющих сообщений?
        /// </summary>
        bool IsWarnEnabled { get; }

        /// <summary>
        /// Включен ли лог для сообщений об ошибках?
        /// </summary>
        bool IsErrorEnabled { get; }

        /// <summary>
        /// Включен ли лог для критических сообщений?
        /// </summary>
        bool IsFatalEnabled { get; }
    }
}
