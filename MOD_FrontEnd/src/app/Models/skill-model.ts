export class Skills{
    public skillId:string;
    public skillName:string;
    public toc:string;
    public fees:number;
    public duration:string;
    
 
    constructor() { 
        this.skillId="S" + Math.round((Math.random()*100));
    } 
    } 