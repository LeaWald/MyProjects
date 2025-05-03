import { useEffect, useState } from "react";
import { getEvent } from "../api/event.api";
import { Event } from "../types/event";
import { NavLink } from "react-router";
import { AddEvent } from "./addEvent.component";
import { Producer } from "../types/producer";
import { getProducerByEmail, updateProducer } from "../api/producer.api";
import { ProducerDetails } from "./producerDetails.component";

export const ExistingProducer = () => {
    const [existProducer, setExistProducer] = useState(false);
    const [addEvent, setAddEvent] = useState(false);
    const [newEventData, setNewEventData] = useState<Event[]>([]);
    const [isFormVisible, setIsFormVisible] = useState(true);
    const [upDateP, setUpDateP] = useState(false);
    const [emailValue, setEmailValue] = useState('');
    const [eventData, setEventData] = useState<Event[]>([]);

    useEffect(() => {
        fetchEvents();
    }, []);

    useEffect(() => {
        if (existProducer) {
            filterEvent(); // יתבצע רק כאשר eventData עודכן
        }
    }, [eventData]);

    const fetchEvents = () => {
        getEvent()
        .then(e => {
            setEventData(e);
            console.log(upDateP);
            console.log(e.length);
            console.log(existProducer);
        })
        .catch((error) => {
            console.log(error);
        });
    }

    const search = async (event: any) => {
        event.preventDefault();
        const email = event.target.email.value;
        setEmailValue(email);
        setIsFormVisible(false)
        let producer = null;
        await getProducerByEmail(emailValue)
            .then((p) => producer = p)
            .catch(() => alert("המפיק/ה לא קיימ/ת"))
        if (producer) {
            filterEvent();
        }
    }
    const filterEvent = () => {
        setExistProducer(true)
        console.log(eventData.length);
        const filteredEvents = eventData.filter((e) => e.producerEmail === emailValue);
        console.log(filteredEvents.length);
        
        setNewEventData(filteredEvents);
    }

    const upDate = async (event: any) => {
        event.preventDefault();
        const newProducer: Producer = {
            name: event.target.name.value,
            email: event.target.email.value,
            phone: event.target.phone.value,
            description: event.target.description.value,
        }
        try {
            await updateProducer(emailValue, newProducer);
            setUpDateP(false);
        } catch (error) {
            console.log(error);
        }
    }
    
    const add =()=>{
        fetchEvents();
    }

    return (
        <div>
            {isFormVisible ? <form onSubmit={search}>
                <input type="email" placeholder="producer email" name="email" required onChange={(event) => setEmailValue(event.target.value)} /> <br />
                <button type="submit">insert</button>
            </form> : ""}
            {newEventData.length > 0 ? (
                newEventData.map((event: any) => (
                    <div>
                        <NavLink to={`/eventOfProducer/${event._id}`}>{"-" + event.name}</NavLink>
                    </div>
                ))
            ) : (
                <p> לא נמצאו אירועים עבור המפיק הזה או שהמפיק לא קיים.</p>
            )}
            {existProducer ? <div> <button onClick={() => setUpDateP(true)}>עדכון פרטי מפיק/ה</button>
                <button onClick={() => setAddEvent(true)}>הוספת ארוע</button>
                <ProducerDetails key={emailValue} email={emailValue} />
            </div> : ""}
            {addEvent ? <AddEvent onEventAdded={add} /> : ""}
            {upDateP ?
                <div><form onSubmit={upDate}>
                    <input type="text" placeholder="new producer name" name="name" /> <br />
                    <input type="email" placeholder="new producer email" name="email" required /> <br />
                    <input type="tel" placeholder="new producer phone" name="phone" /> <br />
                    <input type="text" placeholder="new producer description" name="description" /> <br />
                    <br />
                    <button type="submit">upDate</button>
                </form></div> : ""}

        </div>
    );
}
