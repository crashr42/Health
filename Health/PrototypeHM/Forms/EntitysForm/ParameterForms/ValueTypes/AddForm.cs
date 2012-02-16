﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrototypeHM.DB.DI;
using PrototypeHM.Components;
using PrototypeHM.DB;
using PrototypeHM.DB.Attributes;
using PrototypeHM.DB.DI;
using PrototypeHM.Properties;
using PrototypeHM;
using PrototypeHM.Parameter;

namespace PrototypeHM.Forms.EntitysForm.ParameterForms.ValueTypes
{
    public partial class AddForm : DIForm
    {
        public AddForm(IDIKernel diKernel)
            : base(diKernel)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveClickButtonClick(object sender, EventArgs e)
        {
            try
            {
                //Проверяем на пустое значение
                if (!string.IsNullOrEmpty(NameTextBox.Text))
                {
                    //Получаем делегат сохранения
                    var operationContext =
                    Get<OperationsRepository>().Operations.FirstOrDefault(
                        o => o.GetType() == typeof(OperationsContext<ValueTypeOfMetadata>)) as
                    OperationsContext<ValueTypeOfMetadata>;

                    if (operationContext == null) throw new Exception("Отсутствует контекст операций");

                    var @delegate = operationContext.Save;
                    if (@delegate == null)
                        throw new Exception("Отсутствует метод сохранения.");
                   
                        var dataObject = new ValueTypeOfMetadata {Name = NameTextBox.Text};
                        var qs = @delegate(dataObject);
                    if (qs.Status == 1)
                    {
                        YMessageBox.Information("Успешено сохранено");
                        Close();
                    }
                    else
                    {
                        YMessageBox.Warning(qs.StatusMessage);
                    }
                   
                }
                else
                {
                    YMessageBox.Warning("Пожалуйста укажите название создаваемого типа метаданного");
                }
            }
            catch (Exception exp)
            {

                YMessageBox.Error(string.Format("Пользовательское исключение: {0}", exp.Message));
                Close();
            }
        }
    }
}
