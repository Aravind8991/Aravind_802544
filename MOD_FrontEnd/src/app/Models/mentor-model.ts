export class Mentor{
    public mentorId:string;
    public mentorName:string;
    public email:string;
    public mobileNo:string;
    public password:string;
    public experience:number;
    public skill:string;
    public timeSlot:string;
    public availability:string;
    public active:boolean;
    constructor() { 
        this.mentorId="M" + Math.round((Math.random()*100));
        this.active=true;
        
    } 
}  