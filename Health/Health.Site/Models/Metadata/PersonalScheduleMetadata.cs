﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Health.Core.Entities.POCO;
using Health.Core.Entities.Virtual;
using Health.Core.TypeProvider;

namespace Health.Site.Models.Metadata
{
    public class PersonalScheduleMetadata
    {
        [DisplayName("#")]
        public virtual int Id { get; set; }

        [DisplayName("Пациент")]
        public virtual Patient Patient { get; set; }

        [DisplayName("Параметр")]
        [ClassMetadata(typeof(IfSubParameterMetadata))]
        public virtual Parameter Parameter { get; set; }

        [DisplayName("Дата начала")]
        public virtual DateTime DateStart { get; set; }

        [DisplayName("Дата окончания")]
        public virtual DateTime DateEnd { get; set; }

        [DisplayName("Время начальное")]
        public virtual TimeSpan TimeStart { get; set; }

        [DisplayName("Время окончания")]
        public virtual TimeSpan TimeEnd { get; set; }

        [DisplayName("День")]
        public virtual Day Day { get; set; }

        [DisplayName("Неделя")]
        public virtual Week Week { get; set; }

        [DisplayName("Месяц")]
        public virtual Month Month { get; set; }
    }

    public class PersonalScheduleFormMetadata : PersonalScheduleMetadata
    {
        [Required(ErrorMessage = "Необходимо указать дату начала ввода параметра")]
        public override DateTime DateStart { get; set; }

        [Required(ErrorMessage = "Необходимо указать дату окончаня ввода параметра")]
        public override DateTime DateEnd { get; set; }

        [Required(ErrorMessage = "Укажите время начала ввода параметра")]
        public override TimeSpan TimeStart { get; set; }

        [Required(ErrorMessage = "Укажите время окончания ввода параметра")]
        public override TimeSpan TimeEnd { get; set; }
    }
}