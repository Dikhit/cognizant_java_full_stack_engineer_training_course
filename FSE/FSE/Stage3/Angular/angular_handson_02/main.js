var Department = /** @class */ (function () {
    function Department(name) {
        this.id = new Date().toLocaleTimeString();
        this.name = name;
    }
    return Department;
}());
var Skill = /** @class */ (function () {
    function Skill(name) {
        this.id = new Date().toLocaleTimeString();
        this.name = name;
    }
    return Skill;
}());
var User = /** @class */ (function () {
    function User(name, salary, permenentStaff, department) {
        this.id = new Date().toLocaleTimeString();
        this.name = name;
        this.salary = salary;
        this.permenentStaff = permenentStaff;
        this.department = new Department(department);
        this.skills = [
            new Skill("HTML"),
            new Skill("JavaScript"),
            new Skill("CSS")
        ];
    }
    return User;
}());
var dikhit = new User("Dikhit Kumar Bhuyan", 10000, true, "Programmer Analyst");
var kashmiri = new User("Kashmiri Moni Mahanta", 10000, false, "SDE");
var userContainer = [dikhit, kashmiri];
var getUser = function () {
    userContainer.forEach(function (user) {
        console.log(user);
    });
};
