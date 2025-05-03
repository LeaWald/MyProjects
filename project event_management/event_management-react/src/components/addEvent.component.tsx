import { useState } from "react";
import { createEvent } from "../api/event.api";
import { Event } from '../types/event';


export const AddEvent = (props: any) => {
    const { onEventAdded } = props
    const [isFormVisible, setIsFormVisible] = useState(true);
    const add = async (event: any) => {
        event.preventDefault();
        setIsFormVisible(false);
        const newEvent: Event = {
            name: event.target.name.value,
            description: event.target.description.value,
            producerEmail: event.target.producerEmail.value
        }
        try {
            await createEvent(newEvent);
            onEventAdded();
            setIsFormVisible(false); 
        } catch (error) {
            console.log(error);
        }
    }

    return <div>{isFormVisible ? <form onSubmit={add}>
        <input type="text" placeholder="event name" name="name" /> <br />
        <input type="text" placeholder="event description" name="description" /> <br />
        <input type="text" placeholder="producerEmail" name="producerEmail" /> <br />

        <br />
        <button type="submit">add</button>
    </form> : ""}
    </div>
}