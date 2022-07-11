using System.Collections.Generic;
using System;
public class RStudent : Istudent
{
    private readonly Context db;
    public RStudent(Context _db)
    {
        db = _db;
    }
    public bool Addstudent(Vm_student student)
    {
        try
        {
            Tbl_student tbl_Student = new Tbl_student();
            tbl_Student.Name = student.Name;
            tbl_Student.Family = student.Family;
            db.Tbl_Students.Add(tbl_Student);
            db.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<Vm_student> GetAllstudents()
    {
        List<Vm_student> list = new List<Vm_student>();
        foreach (var item in db.Tbl_Students)
        {
            Vm_student st = new Vm_student();
            st.Id = item.Id;
            st.Name = item.Name;
            st.Family = item.Family;
            list.Add(st);
        }
        return list;
    }
}