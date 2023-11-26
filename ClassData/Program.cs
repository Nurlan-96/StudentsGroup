using ClassData.Domain.Models;

Student[] students = new Student[17];

students[0] = new Student("John Smith", 85);
students[1] = new Student("Alice Johnson", 70);
students[2] = new Student("Michael Brown", 92);
students[3] = new Student("Emma Davis", 78);
students[4] = new Student("William Wilson", 89);
students[5] = new Student("Olivia Taylor", 76);
students[6] = new Student("James Wright", 95);
students[7] = new Student("Sophia Anderson", 82);
students[8] = new Student("Alexander Thomas", 88);
students[9] = new Student("Emily Garcia", 73);
students[10] = new Student("Daniel Hernandez", 91);
students[11] = new Student("Mia Lopez", 79);
students[12] = new Student("Miguel Gonzalez", 87);
students[13] = new Student("Chloe Perez", 74);
students[14] = new Student("Ethan Moore", 90);
students[15] = new Student("Ava Lee", 77);
students[16] = new Student("David Hill", 93);

Student student1 = new("Walter Steen", 89); 
Student student2 = new("Billy McKenna", 67); //bu student elave olunmaycaq, say 18i kecdiyi ucun


Group group1 = new Group("PB513", students);

group1.AddStudent(student1);
group1.AddStudent(student2);
Console.WriteLine(group1.GetStudent(4));
group1.GetAll();
Console.WriteLine(group1.CheckGroupNo());




