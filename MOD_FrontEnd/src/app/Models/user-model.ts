export class User{
    public userId:string;
    public userName:string;
    public email:string;
    public mobilNo:string;
    public password:string;
    public active:boolean;
    constructor() { 
        this.userId="U" + Math.round((Math.random()*100));
        this.active=true;
        
    }   
            



}