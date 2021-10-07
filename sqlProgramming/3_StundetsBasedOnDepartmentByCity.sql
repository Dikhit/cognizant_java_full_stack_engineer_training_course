select 
Student.student_name, Department.department_name 
from Student join Department
on Student.department_id = Department.department_id
where Student.city = "Coimbatore"
order by Student.student_name asc;

