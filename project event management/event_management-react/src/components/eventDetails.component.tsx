import { useParams } from "react-router";

import { Event } from "../types/event";
import { useEffect, useState } from "react";
import { getEventById } from "../api/event.api";
import { ProducerDetails } from "./producerDetails.component";
export const EventDetails = () => {
    const [eventData, setEventData] = useState<Event | null>(null);
    const [producerData, setProducerData] = useState(false);
    const { id } = useParams();

    useEffect( () => {
        getEventById(id).then(p => {
            setEventData(p);
        }).catch((error) => {
            console.log(error);
        });
    }, []);
    return <div>
        {eventData ?
        <div>
                <h3>{eventData.name}</h3>
                <p>Description: {eventData.description}</p>
                <p>producerEmail: {eventData.producerEmail}</p>
            <button onClick={()=>setProducerData(true)}>לפרטי מפיק/ה</button>
                </div>
            :"" }
           
            {producerData && eventData?<ProducerDetails key={eventData.producerEmail} email={eventData.producerEmail}/>:""}
    </div>
}