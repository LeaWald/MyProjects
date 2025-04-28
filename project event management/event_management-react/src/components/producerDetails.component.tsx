import { useEffect, useState } from "react";
import { getProducerByEmail } from "../api/producer.api";
import { Producer } from '../types/producer';


export const ProducerDetails = (props: any) => {
    const { email } = props
    const [producerData, setProducerData] = useState<Producer | null>(null);
    useEffect(() => {
        getProducerByEmail(email).then(p => {
            setProducerData(p);
        }).catch((error) => {
            console.log(error);
        });
    }, [email]);
    return <div>
        {producerData ? (
            <div>
                <h3>{producerData.name}</h3>
                <p>Email: {producerData.email}</p>
                <p>Phone: {producerData.phone}</p>
                <p>Description: {producerData.description}</p>
            </div>
        )
            : (
                <p> אין פרטים על המפיק/ה</p>
            )}
    </div>

}