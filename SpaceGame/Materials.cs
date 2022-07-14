﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpaceGame.DatabaseDataSetTableAdapters;

namespace SpaceGame
{
    class Materials
    {
        private int id;
        private string name, subject;

        public Materials(int _id)
        {
            this.id = _id;
            MaterialsTableAdapter material = new MaterialsTableAdapter();
            DataTable dataTable = material.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("Id = {0}", _id);
            this.name = Convert.ToString(dataView[0]["Name"]);
            this.subject = Convert.ToString(dataView[0]["Subject"]);
        }

        public Materials(string _name, string _subject)
        {
            this.name = _name;
            this.subject = _subject;

            MaterialsTableAdapter materialsTableAdapter = new MaterialsTableAdapter();
            materialsTableAdapter.Insert(_name, _subject);
            this.id = Convert.ToInt32(materialsTableAdapter.GetData().Last()["Id"]);
        }

        public static List<Materials> GetMaterials()
        {
            List<Materials> materials = new List<Materials>();
            MaterialsTableAdapter materialsTableAdapter = new MaterialsTableAdapter();
            DataTable dataTable = materialsTableAdapter.GetData();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                materials.Add(new Materials(Convert.ToInt32(dataRow["Id"])));
            }

            return materials;
        }

        public void Delete()
        {
            MaterialsTableAdapter materialsTableAdapter = new MaterialsTableAdapter();
            SpaceGame.DatabaseDataSet.MaterialsDataTable materials = materialsTableAdapter.GetData();
            materials.Rows.Remove(materials.FindById(this.id));
            materialsTableAdapter.Delete(this.id, this.subject);

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
