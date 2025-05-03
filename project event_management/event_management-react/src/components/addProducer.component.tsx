import { useState } from "react";
import { createProducer } from "../api/producer.api";
import  {Producer} from '../types/producer';
import { ProducerDetails } from "./producerDetails.component";

export const AddProducer = () => {
const [email,setEmail] = useState();
const [alredyAdd,setAlredyAdd] = useState(true)
const add = async (event: any) =>{
    event.preventDefault();
    const newProducer: Producer = {
        name: event.target.name.value,
        email: event.target.email.value,
        phone: event.target.phone.value,
        description: event.target.description.value,
    }
    try {
        await createProducer(newProducer);
        setEmail(event.target.email.value);
        setAlredyAdd(false);
    } catch (error) {
        alert("שגיאה: האימייל כבר קיים במערכת.");
    }
}

      return <div>{alredyAdd?
        <form onSubmit={add}>
        <input type="text" placeholder="producer name" name="name" /> <br />
        <input type="email" placeholder="producer email" name="email" required/> <br />
        <input type="number" placeholder="producer phone" name="phone" /> <br />
        <input type="text" placeholder="producer description" name="description" /> <br />
  
        <br/>
        <button type="submit">add</button>
    </form>:""}
    {email?<ProducerDetails key={email} email={email}/>:""}
  </div>
}

