import { NavLink } from "react-router"

export const ProducerMenu =()=>{
    return <nav id="prod">
        <NavLink to="/addProduer">הוספת מפיקה </NavLink><br />
        <NavLink to="/existingProducer">מפיקה קיימת </NavLink>
    </nav>
}