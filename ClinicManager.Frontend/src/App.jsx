import React, { Component } from 'react';
import axios from 'axios';

import ListClinic from './components/ListClinic';
import Header from './header';
import ModalWindowMore from './modal-window-more/ModalWindowMore';
import './header/header.css';
import './modal-window-more/modal-window-more.css';
import './index.css';
import { URL } from './constants';

export default class App extends Component {
  state = {
    clinicData: [],
  };

  handleMore = (clinicGuid) => {
    
  };

  handleDeleteItem = clinicGuid => {
    this.setState(({ clinicData }) => {
      const idx = clinicData.findIndex(el => el.clinicGuid === clinicGuid);

      const before = clinicData.slice(0, idx);
      const after = clinicData.slice(idx + 1);
      const newArray = [...before, ...after];
      return { clinicData: newArray };
    });
  };

  componentDidMount() {
    axios.get(`${URL}/api/clinic`)
      .then(res => {
        console.log(res);
        const clinicData = res.data;
        this.setState({clinicData});
      })
  }

  render() {
    const { clinicData } = this.state;
    return (
      <div>
        <Header />
        <ListClinic
          clinicData={clinicData}
          onDeleted={this.deleteItem}
          onMore={this.more}
        />
      </div>
    );
  }
}
