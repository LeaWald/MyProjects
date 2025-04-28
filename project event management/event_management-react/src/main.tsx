import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import { MainMenu } from './components/mainMenu.component.tsx'
import {ProducerMenu}from './components/producerMenu.component.tsx'
import {ListEvent}from './components/listEvent.component.tsx'
import './index.css'
// import App from './App.tsx'
import { BrowserRouter, Route, Routes } from 'react-router'
import { AddProducer } from './components/addProducer.component.tsx'
import { ExistingProducer } from './components/existingProducer.component.tsx'
import { EventDetails } from './components/eventDetails.component.tsx'
import { EventOfProducer } from './components/eventOfProducer.component.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
  <BrowserRouter>
      <MainMenu />
    <Routes>
      <Route path="/producer" element={<ProducerMenu/>} />
      <Route path="/user" element={<ListEvent/>} />
      <Route path="/addProduer" element={<AddProducer/>} />
      <Route path="/eventOfProducer/:id" element={<EventOfProducer/>} />
      <Route path="/eventDetails/:id" element={<EventDetails/>} />
      <Route path="/existingProducer" element={<ExistingProducer/>} />
    </Routes>
  </BrowserRouter>
  
</StrictMode>,
)
