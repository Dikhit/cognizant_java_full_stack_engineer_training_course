class Department{
    id: string
    name: string

    constructor(name: string){
        this.id = new Date().toLocaleTimeString();
        this.name = name;
    }
}

class Skill{
    id: string
    name: string

    constructor(name: string){
        this.id = new Date().toLocaleTimeString();
        this.name = name;
    }
}

class User{
    id: string;
    name:string;
    salary:number;
    permenentStaff:boolean;
    department:Department;
    skills:Skill[];

    constructor(name:string, salary:number, permenentStaff:boolean, department:string){
        this.id = new Date().toLocaleTimeString();
        this.name = name;
        this.salary = salary;
        this.permenentStaff = permenentStaff;
        this.department = new Department(department);
        this.skills = [
            new Skill("HTML"),
            new Skill("JavaScript"),
            new Skill("CSS")
        ]
    }
}


const dikhit = new User(
    "Dikhit Kumar Bhuyan", 10000, true, "Programmer Analyst"
);

const kashmiri = new User(
    "Kashmiri Moni Mahanta", 10000, false, "SDE"
);

let userContainer:User[] = [dikhit, kashmiri];

const getUser = () => {
    userContainer.forEach(user => {
        console.log(user);
    });
}