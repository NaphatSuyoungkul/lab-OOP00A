// See https://aka.ms/new-console-template for more information
using lab_OOP00A;
using System;

Console.WriteLine("Naphat Suyoungkul");
Console.WriteLine("653450282-7");
Console.WriteLine("naphat.suy@kkumail.com");
string name = "Yasuo";
int age = 19;
double weight = 140.50;
bool isMan = true;
int sstudentnum = 5;


string name1 = "A";
string name2 = "b";
string name3 = "c";
string name4 = "d";
string name5 = "e";

float wetght1 = 10.2f;
float wetght2 = 12.0f;
float wetght3 = 40.2f;
float wetght4 = 20.7f;
float wetght5 = 22.7f;

Student student1 = new Student();
student1.name = "moragon";
student1.weight = 67.3f;

Student student2= new Student();
student1.name = "Mix";
student1.weight = 66.5f;

Student studen3 = new Student();
student1.name = "flok";
student1.weight = 83.2f;

Student studen4= new Student();
student1.name = "kawpan";
student1.weight = 140.5f;

Student studen5 = new Student();
student1.name = "figo";
student1.weight = 67.5f;

float avgWeight = (student1.weight + student2.weight + studen3.weight + studen4.weight + studen5.weight) / 5;
Console.WriteLine("Weight + avg of Student" + avgWeight);
