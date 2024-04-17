using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Window2
    {
        private unclepistonEntities2 dbContext = new unclepistonEntities2();

        public Window2()
        {
            InitializeComponent();
            DataContext = this;
            usersDataGrid.ItemsSource = dbContext.Пользователь.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
                ShowError("Данные успешно сохранены.");
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void ShowError(string errorMessage)
        {
            Error errorWindow = new Error();
            errorWindow.ShowError(errorMessage);
        }

        private void Button_Click_Word(object sender, RoutedEventArgs e)
        {
            var selectedTable = (tableComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (!string.IsNullOrEmpty(selectedTable))
            {
                var filePath = GetSaveFilePath();
                if (!string.IsNullOrEmpty(filePath))
                {
                    GenerateWordReport(selectedTable, filePath);
                    ShowError("Отчет успешно сформирован и сохранен.");
                }
            }
            else
            {
                ShowError("Выберите таблицу для создания отчета.");
            }
        }

        private string GetSaveFilePath()
        {
            var dialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                DefaultExt = ".docx",
                AddExtension = true
            };

            bool? result = dialog.ShowDialog();

            if (result == true)
                return dialog.FileName;

            return null;
        }

        private void GenerateWordReport(string tableName, string filePath)
        {
            var data = GetDataFromTable(tableName);
            var columnNames = GetColumnNames(tableName); // Получаем названия столбцов из базы данных

            if (data != null && data.Any() && columnNames != null && columnNames.Any())
            {
                // Создаем приложение Word
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                app.Visible = false;

                // Создаем новый документ
                Document doc = app.Documents.Add();

                // Добавляем таблицу
                Table table = doc.Tables.Add(doc.Range(), data.Count + 1, columnNames.Count);

                // Устанавливаем границы для таблицы
                table.Borders.Enable = 1; // Включаем все границы
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle; // Устанавливаем стиль для внешних границ

                // Устанавливаем названия столбцов
                for (int colIndex = 1; colIndex <= columnNames.Count; colIndex++)
                {
                    table.Cell(1, colIndex).Range.Text = columnNames[colIndex - 1];
                }

                // Устанавливаем границы для внутренних горизонтальных линий
                foreach (Row row in table.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        cell.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleSingle;
                    }
                }

                // Устанавливаем границы для внутренних вертикальных линий
                for (int colIndex = 1; colIndex <= table.Columns.Count; colIndex++)
                {
                    foreach (Cell cell in table.Columns[colIndex].Cells)
                    {
                        cell.Borders[WdBorderType.wdBorderRight].LineStyle = WdLineStyle.wdLineStyleSingle;
                    }
                }

                // Заполняем таблицу данными
                int rowIndex = 2; // Начинаем со второй строки
                foreach (var row in data)
                {
                    int colIndex = 1;
                    foreach (var cell in row)
                    {
                        if (cell is DateTime)
                        {
                            table.Cell(rowIndex, colIndex).Range.Text = ((DateTime)cell).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            table.Cell(rowIndex, colIndex).Range.Text = cell.ToString();
                        }
                        colIndex++;
                    }
                    rowIndex++;
                }

                // Сохраняем документ
                doc.SaveAs(filePath);

                // Закрываем Word
                doc.Close();
                app.Quit();
            }
            else
            {
                ShowError("Нет данных для создания отчета или отсутствуют названия столбцов.");
            }
        }

        private List<string> GetColumnNames(string tableName)
        {
            switch (tableName)
            {
                case "Поставщики":
                    return new List<string> { "Название_поставщика", "Адрес", "Телефон" };
                case "Запчасти":
                    return new List<string> { "Название_запчасти", "Производитель", "Цена" };
                case "Клиенты":
                    return new List<string> { "Фамилия", "Имя", "Отчество", "Адрес", "Телефон" };
                case "Сотрудники":
                    return new List<string> { "Фамилия", "Имя", "Отчество", "Должность", "Зарплата" };
                case "Статус_заказа":
                    return new List<string> { "Статус_заказа", "Доставщик_заказа", "Город_отправления_заказа", "Название" };
                default:
                    return null;
            }
        }

        private List<List<object>> GetDataFromTable(string tableName)
        {
            switch (tableName)
            {
                case "Поставщики":
                    return dbContext.Поставщики.Select(Поставщики => new List<object>
            {
                Поставщики.Название_поставщика,
                Поставщики.Адрес,
                Поставщики.Телефон
            }).ToList();
                case "Запчасти":
                    return dbContext.Запчасти.Select(Запчасти => new List<object>
            {
                Запчасти.Название_запчасти,
                Запчасти.Производитель,
                Запчасти.Цена
            }).ToList();
                case "Клиенты":
                    return dbContext.Клиенты.Select(Клиенты => new List<object>
            {
                Клиенты.Фамилия,
                Клиенты.Имя,
                Клиенты.Отчество,
                Клиенты.Адрес,
                Клиенты.Телефон
            }).ToList();
                case "Сотрудники":
                    return dbContext.Сотрудники.Select(Сотрудники => new List<object>
            {
                Сотрудники.Фамилия,
                Сотрудники.Имя,
                Сотрудники.Отчество,
                Сотрудники.Должность,
                Сотрудники.Зарплата
            }).ToList();

                case "Статус_заказа":
                    return dbContext.Статус_заказа.Select(Статус_заказа => new List<object>
            {
                Статус_заказа.Статус_заказа1,
                Статус_заказа.Доставщик_заказа,
                Статус_заказа.Город_отправления_заказа,
                Статус_заказа.Название
            }).ToList();

                default:
                    return null;
            }
        }
        private void TableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Button_Click_Word(sender, e);
        }
    }
}
