export class Training{
    public  trainingId:string;
    public mentorId:string;
    public userId:string;
    public skillId:number;
    public startDate:Date;
    public endDate:Date;
    public timeSlot:string;
    public status:string;
    public progress:string;
    public rating:Float32Array;
    
 
    constructor() { 
        this.trainingId="T" + Math.round((Math.random()*100));
    } 
    } 