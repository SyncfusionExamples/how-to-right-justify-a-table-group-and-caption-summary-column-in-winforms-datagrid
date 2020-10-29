﻿using System;
using System.Collections.ObjectModel;

namespace SfDataGridDemo
{
    public class SalesInfoCollection
    {
        public SalesInfoCollection()
        {
            _SalesDetails = GetSalesInfo();
        }

        private ObservableCollection<SalesByYear> _SalesDetails = null;

        public ObservableCollection<SalesByYear> YearlySalesDetails
        {
            get { return _SalesDetails; }

        }

        /// <summary>
        /// Gets the supplier info.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<SalesByYear> GetSalesInfo()
        {
            var sales = new ObservableCollection<SalesByYear>();
            int i = 0;

            /// <summary>
            /// Collection of ProductNames
            /// </summary>
            string[] productName = new string[]
            {
            "Alice Mutton",
            "NuNuCa Nuß-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute",
            "Gorgonzola Telino",
            "Chartreuse verte",
            "Fløtemysost",
            "Carnarvon Tigers",
            "Thüringer",
            "Vegie-spread",
            "Tarte au sucre",
            "Konbu",
            "Valkoinen suklaa",
            "Queso Manchego",
            "Perth Pasties",
            "Vegie-spread",
            "Tofu",
            "Sir Rodney's",
            "Manjimup Dried Apples"
            };

            var r = new Random();
            while (i < 50)
            {
                var salesByYear = new SalesByYear()
                {
                    Name = productName[r.Next(0, 11)],
                    Q1 = r.Next(10000, 100000) * 0.01,
                    Q2 = r.Next(10000, 100000) * 0.01,
                    Q3 = r.Next(10000, 100000) * 0.01,
                    Q4 = r.Next(10000, 100000) * 0.01,
                };

                sales.Add(salesByYear);
                i++;
            }

            return sales;
        }
    }
}
