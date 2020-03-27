using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlaliWebApplication2
{
    public class Person
    {
        string name;
        string height;
        string mass;
        string hair_color;
        string skin_color;
        string eye_color;
        string birth_year;
        string gender;
        string homeworld;
        string[] films;
        string[] species;
        string[] vehicles;
        string[] starships;
        string created;
        string edited;
        string url;


        public string Name { get => name; set => name = value; }
        public string Height { get => height; set => height = value; }
        public string Mass { get => mass; set => mass = value; }
        public string Hair_color { get => hair_color; set => hair_color = value; }
        public string Skin_color { get => skin_color; set => skin_color = value; }
        public string Eye_color { get => eye_color; set => eye_color = value; }
        public string Birth_year { get => birth_year; set => birth_year = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Homeworld { get => homeworld; set => homeworld = value; }
        public string[] Films { get => films; set => films = value; }
        public string[] Species { get => species; set => species = value; }
        public string[] Vehicles { get => vehicles; set => vehicles = value; }
        public string[] Starships { get => starships; set => starships = value; }
        public string Created { get => created; set => created = value; }
        public string Edited { get => edited; set => edited = value; }
        public string Url { get => url; set => url = value; }
    }
}