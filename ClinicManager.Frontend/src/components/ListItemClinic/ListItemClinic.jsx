import React, { Component } from 'react';
import './ListItemClinic.css';

export default class ListItemClinic extends Component {
  render() {
    const {
      label,
      title,
      address,
      phoneNumber,
      url,
      email,
      specialisation
    } = this.props;

    return (
      <div className="info">
        <span>{title}</span>
        <span>{address}</span>
        <span>{phoneNumber}</span>
        <span>{email}</span>
        <span>{url}</span>
        <span>{specialisation}</span>
        <span>{label}</span>
      </div>
    );
  }
}
