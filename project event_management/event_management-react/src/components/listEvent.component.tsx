import { useEffect, useState } from "react";
import { Event } from "../types/event";
import { getEvent } from "../api/event.api";
import { NavLink } from "react-router";

export const ListEvent = () => {
    const [eventData, seteventData] = useState<Event[]>([]);
    const [eventData2, seteventData2] = useState<Event[]>([]);
    const [searchEvent, setSearchEvent] = useState(false);
    const [allEvent, setAllEvent] = useState(false);
    useEffect(() => {
        getEvent().then(e => {
            seteventData(e);
            console.log(e);
            
        }).catch((error) => {
            console.log(error);
        });
    }, []);
    const search = (event:any)=>{
        event.preventDefault();
        const name = event.target.nameEvent.value;
        console.log(name);
        setAllEvent(true);
        const newEventData = eventData.filter((n)=>n.name == name);
        console.log(newEventData);
        seteventData2(eventData);
        seteventData(newEventData);
        setSearchEvent(false)
    }
    return <div>
        <button onClick={()=>setSearchEvent(true)}>חיפוש</button>
        {eventData.length > 0 ? (
            eventData.map((event:any) => (
                <div>
                    <NavLink to={`/eventDetails/${event._id}`}>{"-"+event.name}</NavLink>
                </div>
            ))
        ) : (
            <p>טוען נתונים...</p>
        )}
        {searchEvent ? (<form onSubmit={search}> 
            <input type="text" placeholder="הכנס שם ארוע" name="nameEvent"/>
            <button type="submit">חפש</button>
            </form>):""}
        {allEvent? <button onClick={()=>seteventData(eventData2)}>כל הארועים</button>:""}
    </div>
}