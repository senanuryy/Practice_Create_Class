using Practice_Create_Class;

Person teacher1 = new Person()
{
    Student = false,
    Name = "Till",
    Surname = "Lindemann",
    BirthDate = "06.01.1963"

};

Person teacher2 = new Person()
{
    Student= false,
    Name = "Can",
    Surname = "Temiz",
    BirthDate = "13.09.1987"
};

Person student1 = new Person()
{
    Student = true,
    Name = "Abraham",
    Surname = "Joseph",
    BirthDate = "22.10.1992"
};

Person student2 = new Person()
{
    Student = true,
    Name = "Austin",
    Surname = "Post",
    BirthDate = "04.07.1995"
};

teacher1.Introduce();
teacher2.Introduce();
student1.Introduce();
student2.Introduce();