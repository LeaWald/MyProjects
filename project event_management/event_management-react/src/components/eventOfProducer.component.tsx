import { useEffect, useState } from "react";
import { Event } from "../types/event";
import { getEvent, removeEvent, upDateEvent } from "../api/event.api";
// import { AddEvent } from "./addEvent.component";
import { useParams } from "react-router";

export const EventOfProducer =()=>{
    const { id } = useParams();
    const [eventData, setEventData] = useState<Event[]>([]);
    const [deleteE, setDeleteE] = useState(true);
    const [upDateE, setUpDateE] = useState("");
    
    useEffect(() => {
        fetchEvents();
    }, []);

    const fetchEvents = () => {
        getEvent()
            .then(e => {
                console.log(e);
                setEventData(e);
                console.log(e);
                
            })
            .catch((error) => {
                console.log(error);
            });
    };
    const deleteEvent = (id: string) => {
        setDeleteE(false)
        removeEvent(id)
            .then(() => {
                fetchEvents();
            })
            .catch((error) => {
                console.log(error);
            });
    };
    const update = (event:any) => {
        event.preventDefault();
        setUpDateE("")
        const newEvent: Event = {
            name: event.target.name.value,
            description: event.target.description.value,
            producerEmail:event.target.producerEmail.value
        }
        upDateEvent(upDateE,newEvent)
            .then(() => {
                fetchEvents();
            })
            .catch((error) => {
                console.log(error);
            });
    };
  const newEventData = eventData.filter((e:any)=>e._id == id)

return <div>
            {newEventData.length > 0 ? (
                newEventData.map((event:any) => (
                    <div>
                        {deleteE? 
                            <div>
                            <h3>{event.name}</h3>
                            <p>description: {event.description}</p>
                            <p>producerEmail: {event.producerEmail}</p>
                            <button onClick = {()=> deleteEvent(event._id)}>x</button>
                            <button onClick = {()=> setUpDateE(event._id)}>עריכה</button>
                            </div>:''}
                    </div>
                ))
            ) : (
                <p></p>
            )}
            <div>{upDateE!= ""?
        <form onSubmit={update}>
        <input type="text" placeholder="new producer name" name="name" /> <br />
        <input type="text" placeholder="new producer description" name="description" /> <br />
        <input type="email" placeholder="new producer email" name="producerEmail" /> <br />
        <br/>
        <button type="submit">upDate</button>
    </form>:""}
  </div>
           
</div>
}